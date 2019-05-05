using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    [Serializable]
    class SygnalTrojkatny: Sygnal
    {
        public SygnalTrojkatny(double A, double T, double kw, double d, double t1)
        {
            this.A = A;
            this.t1 = t1;
            this.T = T;
            this.kw = kw;
            this.d = d;
            signalName = "Sygnał trójkątny";
            IsDiscreteSignal = false;
        }

        public SygnalTrojkatny() { }

        //public override void CalculateXYPoints() {
        //    axisX.Clear();
        //    axisY.Clear();

        //    int z = 0;
        //    double tempStartTime = t1;

        //    for (double i = t1; i < (d + t1); i = i + (1 / f)) {
        //        if (i >= tempStartTime + T) {
        //            z++;
        //            tempStartTime = i;
        //        }
        //        axisX.Add(i);

        //        if (i >= (z * T + t1) && i < (kw * T + z * T + t1)) {
        //            double temp2 = (A / (kw * T)) * (i - z * T - t1);
        //            axisY.Add(temp2);
        //        }
        //        else {
        //            double temp2 = (-A * (i - z * T - t1)) / (T * (1 - kw)) + A / (1 - kw);
        //            axisY.Add(temp2);
        //        }
        //    }
        //}

        public override void CalculateXYPoints() {
            axisX.Clear();
            axisY.Clear();

            for (double i = t1; i < (d + t1); i = i + (1 / f)) {

                double k = Math.Floor((i - t1) / T);

                axisX.Add(i);

                if (i < (k * T + t1) || i < (kw * T + k * T + t1) ){
                    axisY.Add((A / (kw * T) * (i - k * T - t1)));
                }
                else {
                    axisY.Add((-A / (T * (1 - kw)) * (i - k * T - t1) + A / (1 - kw)));
                }
            }
        }

        public override List<double> CalculateYPoints(List<double> axisX) {

            List<double> rAxisY = new List<double>();

            foreach (var point in axisX) {

                double k = Math.Floor((point - t1) / T);

                if (point < (k * T + t1) || point < (kw * T + k * T + t1)) {
                    rAxisY.Add((A / (kw * T) * (point - k * T - t1)));
                }
                else {
                    rAxisY.Add((-A / (T * (1 - kw)) * (point - k * T - t1) + A / (1 - kw)));
                }
            }

            return rAxisY;
        }

        public override Sygnal GetNewSignal() {
            return new SygnalTrojkatny();
        }
    }
}