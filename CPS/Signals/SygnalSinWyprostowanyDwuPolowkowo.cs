using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalSinWyprostowanyDwuPolowkowo: Sygnal
    {
        double y;

        public SygnalSinWyprostowanyDwuPolowkowo(double A, double T, double kw, double d)
        {
                this.A = A;
                this.T = T;
                this.kw = kw;
                this.d = d;
        }

        //public new void PoliczWartoscY()
        //{
        //    for (int i = 0; i < n2; i++)
        //    {
        //        if (FSin(T, i) < 0)
        //        {
        //            y =A*(-1 * FSin(T, i));
        //        }
        //        else
        //        {
        //            y = A*FSin(T, i);
        //        }
        //        this.wartosciSygnaluY.Add(y);
        //    }
        //}
    }
}