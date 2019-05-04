using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    [Serializable]
    class SygnalSin: Sygnal
    {
        public SygnalSin(double A, double T, double t1, double d)
        {
            this.A = A;
            this.T = T;
            this.t1 = t1;
            this.d = d;
            signalName = "Sygnał sinusoidalny";
            IsDiscreteSignal = false;
        }

        public SygnalSin() { }

        public override void CalculateXYPoints() {
            axisX.Clear();
            axisY.Clear();

            for (double i = t1; i < (d + t1); i = i + (1 / f)) {
                axisX.Add(i);
                axisY.Add(A * Math.Sin(((2 * Math.PI) / T) * (i - t1)));
            }
        }

        public override Sygnal GetNewSignal() {
            return new SygnalSin();
        }
    }
}