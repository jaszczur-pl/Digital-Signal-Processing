using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class Operator
    {
        public Sygnal Signal1 { get; set; }
        public Sygnal Signal2 { get; set; }
        public double partOfRange { get; set; }

        public Sygnal AddSignals() {

            Sygnal signal = new Sygnal();
            signal.signalName = "Dodawanie sygnałów";

            int xNumber = Signal1.axisX.Count;

            for (int i = 0; i < xNumber; ++i) {
                signal.axisX.Add(Signal1.axisX[i]);
                signal.axisY.Add(Signal1.axisY[i] + Signal2.axisY[i]);
            }

            return signal;
        }

        public Sygnal SubtractSignals() {

            Sygnal signal = new Sygnal();
            signal.signalName = "Odejmowanie sygnałów";

            int xNumber = Signal1.axisX.Count;

            for (int i = 0; i < xNumber; ++i) {
                signal.axisX.Add(Signal1.axisX[i]);
                signal.axisY.Add(Signal1.axisY[i] - Signal2.axisY[i]);
            }

            return signal;
        }

        public Sygnal MultiplySignals() {

            Sygnal signal = new Sygnal();
            signal.signalName = "Mnożenie sygnałów";

            int xNumber = Signal1.axisX.Count;

            for (int i = 0; i < xNumber; ++i) {
                signal.axisX.Add(Signal1.axisX[i]);
                signal.axisY.Add(Signal1.axisY[i] * Signal2.axisY[i]);
            }

            return signal;
        }

        public Sygnal DivideSignals() {

            Sygnal signal = new Sygnal();
            signal.signalName = "Dzielenie sygnałów";

            int xNumber = Signal1.axisX.Count;

            for (int i = 0; i < xNumber; ++i) {
                if(Signal2.axisY[i] != 0) {
                    signal.axisX.Add(Signal1.axisX[i]);
                    signal.axisY.Add(Signal1.axisY[i] / Signal2.axisY[i]);
                }
            }

            return signal;
        }

        public Sygnal CalculateHistogram(Sygnal lastAffectedSignal, int histValue) {

            Sygnal signal = new Sygnal();

            double range = Math.Abs(lastAffectedSignal.axisY.Max() - lastAffectedSignal.axisY.Min());
            partOfRange = range / histValue;

            for (int i = 1; i < histValue; ++i) {
                signal.axisX.Add(i * partOfRange + lastAffectedSignal.axisY.Min());
                signal.axisY.Add(0);
            }

            signal.axisX.Add(lastAffectedSignal.axisY.Max());
            signal.axisY.Add(0);

            for (int i = 0; i < lastAffectedSignal.axisY.Count; ++i) {
                for (int j = 0; j < signal.axisX.Count; ++j) {
                    if (lastAffectedSignal.axisY[i] <= signal.axisX[j]) {
                        signal.axisY[j] = signal.axisY[j] + 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < signal.axisX.Count; ++i) {
                signal.axisX[i] -= partOfRange * 0.5;
            }

            return signal;
        }

        public double CalculateAverageValue(Sygnal signal) {

            List<double> tempAxisY = new List<double>();
            double duration = 0;
            double averageValue = 0;

            if (!signal.IsDiscreteSignal) {
                if (signal is SzumGaussowski || signal is SkokJednostkowy || signal is SzumJednostajny) {
                    duration = signal.d;
                }
                else {
                    if (signal.d % signal.T == 0) {
                        duration = signal.d;
                    }
                    else {
                        duration = (int)(signal.d / signal.T) * signal.T;
                    }
                }
                for (int i = 0; i < signal.axisY.Count; ++i) {
                    if (duration + signal.axisX[0] >= signal.axisX[i]) {
                        tempAxisY.Add(signal.axisY[i]);
                    }
                    else {
                        break;
                    }
                }
            }
            else {
                for (int i = 0; i < signal.axisY.Count; ++i) {
                    tempAxisY.Add(signal.axisY[i]);
                }
            }

            if (!signal.IsDiscreteSignal) {
                averageValue = (1.0 / duration) * CalculateIntegral(tempAxisY, duration);
            }
            else {
                averageValue = (1.0 / signal.axisY.Count) * CalculateSum(tempAxisY);
            }

            return Math.Round(averageValue, 2);
        }


        private double CalculateIntegral(List<double> axisY, double duration) {

            double integralValue = 0;

            for (int i = 0; i < axisY.Count; ++i) {
                integralValue += axisY[i];
            }

            integralValue *= duration / axisY.Count;
            return integralValue;
        }

        private double CalculateSum(List<double> axisY) {

            double sum = 0;

            for (int i = 0; i < axisY.Count; ++i) {
                sum += axisY[i];
            }

            return sum;
        }
    }
}
