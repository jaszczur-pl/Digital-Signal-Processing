using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalTrojkatny:SCiagly
    {
        double y;
        double t;
        public SygnalTrojkatny(int A, double T, double kw) : base(A, T, kw)
        {

        }

        public void ObliczWartoscY()
        {
            for (int i = 0; i < n2; i++)
            {
                t = i * k;
                if(t>=k*T+t1 || t < kw * T + k * T + t1)
                {
                    y = A / (kw * T) * (t - k * T - t1);
                }
                else if (t>=kw*T+t1+k*T || t<T+k*T+t1)
                {
                    y = -1 * A / (T * (1 - kw)) * (t - k * T - t1) + (A / (1 - kw));
                }
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}