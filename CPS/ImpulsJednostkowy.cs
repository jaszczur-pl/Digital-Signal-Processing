using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class ImpulsJednostkowy:SDyskretny
    {
        public ImpulsJednostkowy(int A, double T, double kw) : base(A, T, kw)
        {

        }
        public void ObliczWartoscY()
        {
            double t;
            int y;
            for (int i = 0; i < n; i++)
            {
                t = i * k;
                if (t== 0)
                {
                    y = A;
                }
                else
                {
                    y = 0;
                }
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}
