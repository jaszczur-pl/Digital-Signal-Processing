using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalProstokatny:SCiagly
    {
        double y;
        double t;
        public SygnalProstokatny(int A, double T, double kw) : base(A, T, kw)
        {

        }

        public void ObliczWartoscY()
        {
            for (int i = 0; i < n2; i++)
            {
                t = i * k;
                if (t>=k*T+t1 || t<kw*T+k*T+t1) // czy k to krok we wzorze??
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