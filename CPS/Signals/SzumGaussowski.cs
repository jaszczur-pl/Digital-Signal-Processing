using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    [Serializable]
    class SzumGaussowski: Sygnal
    {
        public SzumGaussowski(double A, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            signalName = "Sygnał Gaussowski";
            IsDiscreteSignal = false;
        }

        public SzumGaussowski() { }

        public override void CalculateXYPoints() {
            axisX.Clear();
            axisY.Clear();

            Random randomValue = new Random();

            for (double i = t1; i < (d + t1); i = i + (1 / f)) {

                axisX.Add(i);

                double temp = A / 3;
                double u1 = 1.0 - randomValue.NextDouble();
                double u2 = 1.0 - randomValue.NextDouble();
                double function = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

                axisY.Add(function * temp);
            }
        }

        public override List<double> CalculateYPoints(List<double> axisX) {

            List<double> rAxisY = new List<double>();
            Random randomValue = new Random();

            foreach (var point in axisX) {
                double temp = A / 3;
                double u1 = 1.0 - randomValue.NextDouble();
                double u2 = 1.0 - randomValue.NextDouble();
                double function = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

                rAxisY.Add(function * temp);
            }

            return rAxisY;
        }

        public override Sygnal GetNewSignal() {
            return new SzumGaussowski();
        }
    }
}