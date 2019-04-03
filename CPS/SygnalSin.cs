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
        public SygnalSin(int A, int T) : base(A, T)
        {

        }

        public double FSin(int A, double T)
        {
            double x = A * Math.Sin((2*Math.PI)/T*(t1-t2));
            return x;
        }

        public void PoliczWartoscY()
        {
            for (int i = 0; i < n; i++)
            {
                y = FSin(A,T);
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}