using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SkokJednostkowy:SCiagly
    {
        double t;
        double y;
        public SkokJednostkowy(int A, double T, double kw) : base(A, T, kw)
        {

        }

        public void ObliczWartoscY()
        {
            for (int i = 0; i < n; i++)
            {
                t = i * k;
                if (t > ts)
                {
                    y = A;
                }
                else if (t == ts)
                {
                    y = A / 2;
                }
                else if (t < ts)
                {
                    y = 0;
                }
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}