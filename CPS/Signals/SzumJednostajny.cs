using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    [Serializable]
    class SzumJednostajny : Sygnal
    {
        public SzumJednostajny(double A, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            p = 0.5;
            signalName = "Szum jednostajny";
            IsDiscreteSignal = false;
        }

        public override void CalculateXYPoints() {

            Random r = new Random();

            for (double i = t1; i < (d + t1); i = i + (d / (numberOfSamples / 100))) {
                int randomNumber = r.Next(1, 11);
                int probability = (int)(p * 10);

                axisX.Add(i);

                if (randomNumber <= probability) {
                    axisY.Add(A);
                }
                else {
                    axisY.Add(-A);
                }
            }
        }
    }
}
