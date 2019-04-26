using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class ImpulsJednostkowy: Sygnal
    {
        public ImpulsJednostkowy(double A, double n1, double ns, double d, double f)
        {
            this.A = A;
            this.n1 = n1;
            this.ns = ns;
            this.d = d;
            this.f = f;
            signalName = "Impuls jednostkowy";
        }

        public override void CalculateXYPoints() {
            double counter = n1;

            for (double i = n1; i < (d + n1); i = i + (d / f)) {
                axisX.Add(i);
                if (ns == counter) {
                    axisY.Add(A);
                }
                else {
                    axisY.Add(0);
                }
                ++counter;
            }
        }
    }
}
