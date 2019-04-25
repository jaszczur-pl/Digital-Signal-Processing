using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalProstokatny: Sygnal
    {
        double y;
        double t;
        public SygnalProstokatny(double  A, double T, double kw, double d, double t1)
        {
            this.A = A;
            this.t1 = t1;
            this.T = T;
            this.kw = kw;
            this.d = d;
        }

        //public void ObliczWartoscY()
        //{
        //    for (int i = 0; i < n2; i++)
        //    {
        //        t = i * k;
        //        if (t>=k*T+t1 || t<kw*T+k*T+t1) // czy k to krok we wzorze??
        //        {
        //            y = A;
        //        }
        //        else
        //        {
        //            y = 0;
        //        }
        //        this.wartosciSygnaluY.Add(y);
        //    }
        //}

    }
}