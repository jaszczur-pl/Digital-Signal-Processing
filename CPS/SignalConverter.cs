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

        private static List<double> MakeSignalsComparable(Sygnal quantizedSignal) {

            return quantizedSignal.CalculateYPoints(quantizedSignal.axisX);
        }

        public double CalculateMeanSquaredErrorPowerValue(Sygnal quantizedSignal) {

            List<double> comparable = MakeSignalsComparable(quantizedSignal);

            double mseSum = 0;

            int numberOfPoints = quantizedSignal.axisX.Count;

            for (int i = 0; i < numberOfPoints; i++) {
                mseSum += Math.Pow((comparable[i] - quantizedSignal.axisY[i]), 2);
            }

            return Math.Round(mseSum / numberOfPoints, 4);
        }

        public double CalculateSignalToNoiseRatioValue(Sygnal quantizedSignal) {

            List<double> comparable = MakeSignalsComparable(quantizedSignal);
            double nominator = 0;
            double denominator = 0;

            int numberOfPoints = quantizedSignal.axisX.Count;

            for (int i =0; i < numberOfPoints -1; i++) {
                denominator += Math.Pow((comparable[i] - quantizedSignal.axisY[i]), 2);
            }
            for (int i = 0; i < numberOfPoints - 1; i++) {
                nominator += Math.Pow(comparable[i], 2);
            }

            return 10.0 * Math.Log10(nominator / denominator);
        }

        public double CalculatePeakSignalToNoiseRatioValue(Sygnal quantizedSignal) {
            List<double> comparable = MakeSignalsComparable(quantizedSignal);
            double max = comparable[0];
            int numberOfPoints = quantizedSignal.axisX.Count;

            for (int i = 1; i < numberOfPoints -1; i++) {

                if (comparable[i] > max) {
                    max = comparable[i];
                }
            }

            return 10.0 * Math.Log10(max / CalculateMeanSquaredErrorPowerValue(quantizedSignal));
        }

        public double CalculateMaxDifferenceValue(Sygnal quantizedSignal) {
            List<double> comparable = MakeSignalsComparable(quantizedSignal);
            double max = Math.Abs(comparable[0] - quantizedSignal.axisY[0]);
            int numberOfPoints = quantizedSignal.axisX.Count;

            for (int i = 1; i < numberOfPoints - 1; i++) {
                double absValue = Math.Abs(comparable[i] - quantizedSignal.axisY[i]);

                if (absValue > max) {
                    max = absValue;
                }
            }

            return max;
        }

    }
}
