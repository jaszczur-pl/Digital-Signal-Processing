﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalProstokatny: Sygnal
    {
        public SygnalProstokatny(double  A, double T, double kw, double d, double t1)
        {
            this.A = A;
            this.t1 = t1;
            this.T = T;
            this.kw = kw;
            this.d = d;
            signalName = "Sygnał prostokątny";
        }

        public override void CalculateXYPoints() {
            throw new NotImplementedException();
        }

        //public void CalculateXYPoints()
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
        //        this.axisY.Add(y);
        //    }
        //}

    }
}