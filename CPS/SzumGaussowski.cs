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
        public SzumGaussowski(int A, int T, double kw) : base(A, T, kw)
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

                    int Amin = (A/2 * -1);
                    int Amax = A/2;

                    Random r = new Random();
                    v1 = 2 * r.Next(Amin * 10000, Amax * 10000) / 10000;   // pomiedzy -A i A
                    v2 = 2 * r.Next(Amin * 10000, Amax * 10000) / 10000;   
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