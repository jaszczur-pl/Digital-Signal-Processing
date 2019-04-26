using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalSinWyprostowanyDwuPolowkowo: Sygnal
    {
        public SygnalSinWyprostowanyDwuPolowkowo(double A, double T, double t1, double d)
        {
            this.A = A;
            this.T = T;
            this.t1 = t1;
            this.d = d;
            signalName = "Sygnał sinusoidalny wyprostowany dwupołówkowo";
        }

        public override void CalculateXYPoints() {
            throw new NotImplementedException();
        }

        //public new void CalculateXYPoints()
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
        //        this.axisY.Add(y);
        //    }
        //}
    }
}