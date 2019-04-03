using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace CPS
{
    class SzumGaussowski: SCiagly
    {
        double y;
        public SzumGaussowski(int A, int T) : base(A, T)
        {

        }

        private double nextNextGaussian;
        private bool haveNextNextGaussian = false;

        public double nextGaussian()
        {
            if (haveNextNextGaussian)
            {
                haveNextNextGaussian = false;
                return nextNextGaussian;
            }
            else
            {
                double v1, v2, s;
                do
                {
                    Random r = new Random();
                    v1 = 2 * r.NextDouble() - 1;   // between -1.0 and 1.0
                    v2 = 2 * r.NextDouble() - 1;   // between -1.0 and 1.0
                    s = v1 * v1 + v2 * v2;
                } while (s >= 1 || s == 0);
                double multiplier = Math.Sqrt(-2 * Math.Log(s) / s);
                nextNextGaussian = v2 * multiplier;
                haveNextNextGaussian = true;
                return v1 * multiplier;
            }
        }

       /* public double ObliczPodstawe()
        {
        double podstawa = 1/(1*Math.Sqrt(2 * Math.PI));
        return podstawa;
        }

        public double ObliczPotege(double x)
        {
            double potega = (-1 * (x * x)) / 2;
            return potega;
        }*/
        
        public void PoliczWartoscY()
        {
            for (int i = 0; i < n; i++)
            {
                y = nextGaussian();
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}