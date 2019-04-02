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
        public double ObliczPodstawe()
        {
        double podstawa = 1/(1*Math.Sqrt(2 * Math.PI));
        return podstawa;
        }

        public double ObliczPotege(double x)
        {
            double potega = (-1 * (x * x)) / 2;
            return potega;
        }
        
        public void PoliczWartoscY()
        {
            for (int i = 0; i < n; i++)
            {
                 
                y = Math.Pow(ObliczPodstawe(), ObliczPotege(i*k));
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}