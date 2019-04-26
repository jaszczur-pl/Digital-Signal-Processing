using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalProstokatnySymetryczny: Sygnal
    {
        public SygnalProstokatnySymetryczny(double A, double T, double kw, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.T = T;
            this.kw = kw;
            this.d = d;
            signalName = "Sygnał prostokątny symetryczny";
        }

        public override void CalculateXYPoints() {
            throw new NotImplementedException();
        }

        //public void CalculateXYPoints()
        //{
        //    for (int i = 0; i < n2; i++)
        //    {
        //        t = i * k;
        //        if (t >= k * T + t1 || t < kw * T + k * T + t1) // czy k to krok we wzorze??
        //        {
        //            y = A;
        //        }
        //        else
        //        {
        //            y = -1*A;
        //        }
        //        this.axisY.Add(y);
        //    }
        //}
    }
}