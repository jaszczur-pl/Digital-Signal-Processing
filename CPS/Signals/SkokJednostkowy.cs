using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    [Serializable]
    class SkokJednostkowy: Sygnal
    {
        public SkokJednostkowy(double A, double t1, double d, double ts)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            this.ts = ts;
            signalName = "Skok jednostkowy";
            IsDiscreteSignal = false;
        }

        public SkokJednostkowy() { }

        public override void CalculateXYPoints() {
            axisX.Clear();
            axisY.Clear();

            for (double i = t1; i < (d + t1); i = i + (1 / f)) {
                axisX.Add(i);

                if (i > ts) {
                    axisY.Add(A);
                }
                else if (i == ts) {
                    axisY.Add(A / 2);
                }
                else if (i < ts) {
                    axisY.Add(0);
                }
            }
        }

        public override List<double> CalculateYPoints(List<double> axisX) {

            List<double> rAxisY = new List<double>();

            foreach(var point in axisX) {

                    if (point > ts) {
                        rAxisY.Add(A);
                    }
                    else if (point == ts) {
                        rAxisY.Add(A / 2);
                    }
                    else if (point < ts) {
                        rAxisY.Add(0);
                    }
            }

            return rAxisY;
        }

        public override Sygnal GetNewSignal() {
            return new SkokJednostkowy();
        }
    }
}