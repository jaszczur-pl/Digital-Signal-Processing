using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalSin:SCiagly
    {
        double y;
        public SygnalSin(int A, double T, double kw) : base(A, T, kw)
        {

        }

        public double FSin( double T, int i)
        {
            double t = i * k;
            double x = Math.Sin((2*Math.PI)/T*(t-t1));
            return x;
        }

        public void PoliczWartoscY()
        {
            for (int i = 0; i < n; i++)
            {
                y = A*FSin(T,i);
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}