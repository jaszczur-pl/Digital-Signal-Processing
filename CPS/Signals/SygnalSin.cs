﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalSin: Sygnal
    {
        double y;

        public SygnalSin(double A, double T, double kw, double d)
        {
            this.A = A;
            this.T = T;
            this.kw = kw;
            this.d = d;
        }

        //public double FSin( double T, int i)
        //{
        //    double t = i * k;
        //    double x = Math.Sin((2*Math.PI)/T*(t-t1));
        //    return x;
        //}

        //public void PoliczWartoscY()
        //{
        //    for (int i = 0; i < n2; i++)
        //    {
        //        y = A*FSin(T,i);
        //        this.wartosciSygnaluY.Add(y);
        //    }
        //}
    }
}