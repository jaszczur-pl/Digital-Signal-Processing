using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SkokJednostkowy: Sygnal
    {
        public SkokJednostkowy(double A, double t1, double d, double ts)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            this.ts = ts;
            signalName = "Skok jednostkowy";
        }

        //public void CalculateXYPoints()
        //{
        //    for (int i = 0; i < n2; i++)
        //    {
        //        t = i * k;
        //        if (t > ts)
        //        {
        //            y = A;
        //        }
        //        else if (t == ts)
        //        {
        //            y = A / 2;
        //        }
        //        else if (t < ts)
        //        {
        //            y = 0;
        //        }
        //        this.axisY.Add(y);
        //    }
        //}
    }
}