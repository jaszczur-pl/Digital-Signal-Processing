using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace CPS
{
    class SzumGaussowski: Sygnal
    {
        public SzumGaussowski(double A, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            signalName = "Sygnał Gaussowski";
        }

        public override void CalculateXYPoints() {
            Random randomValue = new Random();

            for (double i = t1; i < (d + t1); i = i + (d / (numberOfSamples / 100))) {

                axisX.Add(i);

                double temp = A / 3;
                double u1 = 1.0 - randomValue.NextDouble();
                double u2 = 1.0 - randomValue.NextDouble();
                double function = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

                axisY.Add(function * temp);
            }
        }
    }
}