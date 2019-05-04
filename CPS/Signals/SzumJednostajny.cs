using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    [Serializable]
    class SzumJednostajny : Sygnal
    {
        public SzumJednostajny(double A, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            p = 0.5;
            signalName = "Szum jednostajny";
            IsDiscreteSignal = false;
        }

        public SzumJednostajny() { }

        public override void CalculateXYPoints() {
            axisX.Clear();
            axisY.Clear();

            Random r = new Random();

            for (double i = t1; i < (d + t1); i = i + (1 /f)) {

                axisX.Add(i);
                double rand = r.NextDouble() * (A + A) - A;
                axisY.Add(rand);

            }
        }

        public override List<double> CalculateYPoints(List<double> axisX) {

            List<double> rAxisY = new List<double>();
            Random r = new Random();

            foreach (var point in axisX) {
                double rand = r.NextDouble() * (A + A) - A;
                rAxisY.Add(rand);
            }

            return rAxisY;
        }

        public override Sygnal GetNewSignal() {
            return new SzumJednostajny();
        }
    }
}
