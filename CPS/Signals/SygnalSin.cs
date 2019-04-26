using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalSin: Sygnal
    {
        public SygnalSin(double A, double T, double t1, double d)
        {
            this.A = A;
            this.T = T;
            this.t1 = t1;
            this.d = d;
            signalName = "Sygnał sinusoidalny";
        }

        //public double FSin( double T, int i)
        //{
        //    double t = i * k;
        //    double x = Math.Sin((2*Math.PI)/T*(t-t1));
        //    return x;
        //}

        //public void CalculateXYPoints()
        //{
        //    for (int i = 0; i < n2; i++)
        //    {
        //        y = A*FSin(T,i);
        //        this.axisY.Add(y);
        //    }
        //}
    }
}