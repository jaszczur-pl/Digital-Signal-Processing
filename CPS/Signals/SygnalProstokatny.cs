using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    [Serializable]
    class SygnalProstokatny: Sygnal
    {
        public SygnalProstokatny(double  A, double T, double kw, double d, double t1)
        {
            this.A = A;
            this.t1 = t1;
            this.T = T;
            this.kw = kw;
            this.d = d;
            signalName = "Sygnał prostokątny";
            IsDiscreteSignal = false;
        }

        public SygnalProstokatny() { }

        public override void CalculateXYPoints() {
            axisX.Clear();
            axisY.Clear();

            int z = 0;
            double tempStartTime = t1;

            for (double i = t1; i < (d + t1); i = i + (1/ f)) {
                if (i >= tempStartTime + T) {
                    z++;
                    tempStartTime = i;
                }
                axisX.Add(i);
                if (i >= (z * T + t1) && i < (kw * T + z * T + t1)) {
                    axisY.Add(A);
                }
                else {
                    axisY.Add(0);
                }
            }
        }

        public override List<double> CalculateYPoints(List<double> axisX) {

            List<double> rAxisY = new List<double>();
            int z = 0;
            double tempStartTime = t1;

            foreach (var point in axisX) {

                if (point >= tempStartTime + T) {
                    z++;
                    tempStartTime = point;
                }

                if (point >= (z * T + t1) && point < (kw * T + z * T + t1)) {
                    rAxisY.Add(A);
                }
                else {
                    rAxisY.Add(0);
                }
            }

            return rAxisY;
        }


        public override Sygnal GetNewSignal() {
            return new SygnalProstokatny();
        }
    }
}