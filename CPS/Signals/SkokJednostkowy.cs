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

        public override void CalculateXYPoints() {

            for (double i = t1; i < (d + t1); i = i + (d / numberOfSamples)) {
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
    }
}