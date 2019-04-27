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
            this.f = f;
            this.p = p;
            signalName = "Szum impulsowy";
            IsDiscreteSignal = true;
        }

        public override void CalculateXYPoints() {

            Random r = new Random();

            for (double i = t1; i < (d + t1); i = i + (d / f)) {
                int rand = r.Next(0, 100);
                double randomValue = ((double)rand / 100.0);
                double probability = p ;

                axisX.Add(i);
                if (randomValue < probability) {
                    axisY.Add(A);
                }
                else {
                    axisY.Add(0);
                }
            }
        }
    }
}
