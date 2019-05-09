using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SignalFilter
    {
        public Sygnal MakeConvolution(Sygnal signal1, Sygnal signal2) {

            Sygnal convolutedSignal = new Sygnal();
            convolutedSignal.IsDiscreteSignal = true;

            int numberOfElements = signal1.axisX.Count + signal2.axisX.Count - 1;

            for (int i=0; i < numberOfElements; i++) {
                double sum = 0;

                for (int k=0; k < signal1.axisX.Count; k++) {

                    if (i - k >= 0 && i - k < signal2.axisX.Count) {
                        sum += signal1.axisY[k] * signal2.axisY[i - k];
                    }

                }
                convolutedSignal.axisX.Add(i);
                convolutedSignal.axisY.Add(sum);

            }

            return convolutedSignal;
        }

        public Sygnal MakeSignalsCorrelation(Sygnal signal1, Sygnal signal2) {
            Sygnal correlatedSignal = signal2.GetNewSignal();
            
            for (int i=0; i < signal2.axisX.Count; i++) {
                correlatedSignal.axisX.Add(signal2.axisX[i]);
                correlatedSignal.axisY.Add(signal2.axisY[i]);
            }

            correlatedSignal.axisY.Reverse();
            correlatedSignal = MakeConvolution(signal1, correlatedSignal);

            return correlatedSignal;
        }

        public Sygnal MakeSignalFiltration(Sygnal signal, int filteringLevel, int cutFrequency,
            string filterType, string windowType) {

            Sygnal filteredSignal = new Sygnal();
            List<double> tempList = new List<double>();

            for (int i = 0; i < signal.axisY.Count; i++) {
                filteredSignal.axisY.Add(signal.axisY[i]);
            }

            double K = signal.f / cutFrequency;

            if (filterType == "Dolnoprzepstowy" || windowType == "Prostokątny") {
                tempList = ImpulseAnswerBottomRec(filteringLevel, K);
            } else if (filterType == "Dolnoprzepustowy" || windowType == "Hanninga") {
                tempList = ImpulseAnswerBottomHan(filteringLevel, K);
            } else if (filterType == "Górnoprzepustowy" || windowType == "Prostokątny") {
                tempList = ImpulseAnswerTop(ImpulseAnswerBottomRec(filteringLevel, K));
            } else if (filterType == "Górnoprzepustowy" || windowType == "Hanninga") {
                tempList = ImpulseAnswerTop(ImpulseAnswerBottomHan(filteringLevel, K));
            }

            filteredSignal = SpliceOfSignals(tempList, filteredSignal.axisY, signal.d);

            return filteredSignal;
        }

        private static List<double> ImpulseAnswerTop(List<double> bottom) {
            List<double> points = new List<double>();

            for (int n = 0; n < bottom.Count; n++) {
                points.Add(bottom[n] * Math.Pow(-1, n));
            }

            return points;
        }

        private static List<double> ImpulseAnswerBottomHan(int M, Double K) {

            List<Double> points = new List<double>();
            for (int n = 0; n < M; n++) {
                if (n == (M - 1.0) / 2.0) {
                    points.Add(2 / K * CalculateHanningWindow(n, M));
                }
                else {
                    points.Add(Math.Sin(2.0 * Math.PI * ((double)n - (M - 1.0) / 2.0) / K) / (Math.PI * ((double)n - (M - 1.0) / 2.0)) * CalculateHanningWindow(n, M));
                }

            }
            return points;
        }

        public static List<double> ImpulseAnswerBottomRec(int M, double K) {

            List<double> points = new List<double>();
            for (int n = 0; n < M; ++n) {
                if (n == (M - 1.0) / 2.0) {
                    points.Add(2 / K);
                }
                else {
                    points.Add(Math.Sin(2.0 * Math.PI * ((double)n - (M - 1.0) / 2.0) / K) / (Math.PI * ((double)n - (M - 1.0) / 2.0)));
                }
            }
            return points;
        }

        private static double CalculateHanningWindow(int n, double M) {
            return 0.5 - 0.5 * Math.Cos(2 * Math.PI * (double)n / M);
        }

        private static Sygnal SpliceOfSignals(List<double> answer, List<double> input, double lastTime) {
            Sygnal splicedSignal = new Sygnal();
            int M = answer.Count;
            int N = input.Count;

            double T = lastTime / (M + N - 1);
            for (int n = 0; n < M + N - 1; ++n) {
                double sum = 0.0;
                for (int k = 0; k < M; ++k) {
                    if (k < M && (n - k) >= 0 && (n - k) < N) {
                        sum += answer[k] * input[n - k];
                    }
                }

                splicedSignal.axisX.Add((double)n * T);
                splicedSignal.axisY.Add(sum);
            }
            return splicedSignal;
        } 
    }
}
