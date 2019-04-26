using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    [Serializable]
    class SzumImpulsowy: Sygnal
    {
        public SzumImpulsowy(double A, double t1, double d, double f , double p)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            this.f = (int)f;
            this.p = p;
            signalName = "Szum impulsowy";
            IsDiscreteSignal = true;
        }

        public override void CalculateXYPoints() {

            Random r = new Random();

            for (double i = t1; i < (d + t1); i = i + (d / f)) {
                int randomValue = r.Next(1, 1001);
                int probability = (int)(p * 1000);

                axisX.Add(i);
                if (randomValue <= probability) {
                    axisY.Add(A);
                }
                else {
                    axisY.Add(0);
                }
            }
        }
    }
}
