using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SignalConverter
    {
        public Sygnal EvenSampling(Sygnal signal, double frequency) {

            Sygnal quantizedSignal = signal.GetNewSignal();
            quantizedSignal.f = frequency;
            quantizedSignal.A = signal.A;
            quantizedSignal.d = signal.d;
            quantizedSignal.T = signal.T;
            quantizedSignal.t1 = signal.t1;
            quantizedSignal.p = signal.p;
            quantizedSignal.kw = signal.kw;
            quantizedSignal.ts = signal.ts;

            quantizedSignal.CalculateXYPoints();

            return quantizedSignal;
        }

        public Sygnal UniformQuantization(Sygnal signal, double frequency, int numberOfQuantizationLevels) {

            Sygnal quantizedSignal = new Sygnal();
            List<double> tempAxisY = new List<double>();

            quantizedSignal = EvenSampling(signal, frequency);

            double max = quantizedSignal.axisY[0];
            double min = quantizedSignal.axisY[0];

            for(int i = 0; i < quantizedSignal.axisY.Count; i++) {
                if (max < quantizedSignal.axisY[i]) {
                    max = quantizedSignal.axisY[i];
                }

                if (min > quantizedSignal.axisY[i]) {
                    min = quantizedSignal.axisY[i];
                }
            }

            double subtraction = max - min;

            SortedSet<double> treeSet = new SortedSet<double>();

            for(int i = 0; i < numberOfQuantizationLevels; i++) {
                treeSet.Add(min + ((subtraction / numberOfQuantizationLevels) * i));
            }

            for(int i = 0; i < quantizedSignal.axisY.Count; i++) {
                double tempY;
                tempY = treeSet.GetViewBetween(long.MinValue, quantizedSignal.axisY[i]).Max;

                tempAxisY.Add(tempY);
            }

            quantizedSignal.axisY = tempAxisY;

            return quantizedSignal;
        }

        public Sygnal ExtrapolationOfZeroOrder(Sygnal signal, double frequency, double conversionFrequency) {

            Sygnal quantizedSignal = new Sygnal();
            List<double> tempAxisX = new List<double>();
            List<double> tempAxisY = new List<double>();

            quantizedSignal = EvenSampling(signal, frequency);

            double step = 1 / conversionFrequency;

            double baseSignalStep = quantizedSignal.axisX.ElementAt(1) - quantizedSignal.axisX.ElementAt(0);
            int k = 0;

            foreach(double pointX in quantizedSignal.axisX) {

                for (double i = pointX; i < pointX + baseSignalStep; i += step) {
                    tempAxisX.Add(i);
                    tempAxisY.Add(quantizedSignal.axisY[k]);
                }

                k++;
            }

            quantizedSignal.axisX = tempAxisX;
            quantizedSignal.axisY = tempAxisY;

            return quantizedSignal;
        }

        public Sygnal ReconstructionBasedOnSincFunction(Sygnal signal, double frequency, double conversionFrequency) {
            Sygnal quantizedSignal = new Sygnal();
            List<double> tempAxisX = new List<double>();
            List<double> tempAxisY = new List<double>();

            quantizedSignal = EvenSampling(signal, frequency);

            double baseSignalStep = quantizedSignal.axisX.ElementAt(1) - quantizedSignal.axisX.ElementAt(0);

            double numberOfProbes = (quantizedSignal.axisX[quantizedSignal.axisX.Count - 1] + (1.0 / (1.5 * conversionFrequency)));

            for (double t = quantizedSignal.axisX[0]; t <= numberOfProbes; t += (1 / conversionFrequency)) {
                double sum = 0;

                for (int i = 0; i < quantizedSignal.axisY.Count; i++) {
                    double arg = t / baseSignalStep - i;
                    sum += quantizedSignal.axisY[i] * SincFunction(arg);
                }

                tempAxisX.Add(t);
                tempAxisY.Add(sum);
            }

            quantizedSignal.axisX = tempAxisX;
            quantizedSignal.axisY = tempAxisY;

            return quantizedSignal;
        }

        private static double SincFunction(double t) {
            if (t == 0) {
                return 1;
            } else {
                return Math.Sin(Math.PI * t) / (Math.PI * t);
            }
        }

        private static List<double> MakeItComparable(Sygnal signal, Sygnal quantizedSignal) {

            Sygnal tempSignal = signal.GetNewSignal();
            tempSignal.f = 1000;
            tempSignal.A = signal.A;
            tempSignal.d = signal.d;
            tempSignal.T = signal.T;
            tempSignal.t1 = signal.t1;
            tempSignal.p = signal.p;
            tempSignal.kw = signal.kw;
            tempSignal.ts = signal.ts;



        }

        public double CalculateMeanSquaredErrorPowerValue(Sygnal signal, Sygnal quantizedSignal) {

        }

    }
}
