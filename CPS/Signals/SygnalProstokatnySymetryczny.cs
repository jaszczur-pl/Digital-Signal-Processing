using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalProstokatnySymetryczny: Sygnal
    {
        public SygnalProstokatnySymetryczny(double A, double T, double kw, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.T = T;
            this.kw = kw;
            this.d = d;
            signalName = "Sygnał prostokątny symetryczny";
        }

        public override void CalculateXYPoints() {

            int z = 0;
            double tempStartTime = t1;

            for (double i = t1; i < (d + t1); i = i + (d / numberOfSamples)) {
                if (i >= tempStartTime + T) {
                    z++;
                    tempStartTime = i;
                }
                axisX.Add(i);
                if (i >= (z * T + t1) && i < (kw * T + z * T + t1)) {
                    axisY.Add(A);
                }
                else {
                    axisY.Add(-1 * A);
                }
            }
        }
    }
}