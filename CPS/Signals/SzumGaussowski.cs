﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace CPS
{
    class SzumGaussowski: Sygnal
    {
        double y;

        public SzumGaussowski(double A, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            signalName = "Sygnał Gaussowski";
        }

        private double nextNextGaussian;
        private bool haveNextNextGaussian = false;

        //public double nextGaussian()
        //{
        //    if (haveNextNextGaussian)
        //    {
        //        haveNextNextGaussian = false;
        //        return nextNextGaussian;
        //    }
        //    else
        //    {
        //        double v1, v2, s;
        //        do
        //        {

        //            int Amin = (A/2 * -1);
        //            int Amax = A/2;

        //            Random r = new Random();
        //            v1 = 2 * r.Next(Amin * 10000, Amax * 10000) / 10000;   // pomiedzy -A i A
        //            v2 = 2 * r.Next(Amin * 10000, Amax * 10000) / 10000;   
        //            s = v1 * v1 + v2 * v2;
        //        } while (s >= 1 || s == 0);
        //        double multiplier = Math.Sqrt(-2 * Math.Log(s) / s);
        //        nextNextGaussian = v2 * multiplier;
        //        haveNextNextGaussian = true;
        //        return v1 * multiplier;
        //    }
        //}

        
        //public void PoliczWartoscY()
        //{
        //    for (int i = 0; i < n2; i++)
        //    {
        //        y = nextGaussian();
        //        this.axisY.Add(y);
        //    }
        //}
    }
}