using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SzumJednostajny : Sygnal
    {
        double y;

        public SzumJednostajny(double A, double T, double kw)
        {
            this.A = A;
            this.T = T;
            this.kw = kw;
        }

        public double Generuj(double A)
        {
            double Amin = (A/2 * -1);
            double Amax = A/2;
            
            Random r = new Random(System.DateTime.Now.Millisecond);
            double x = (double)(r.Next((int)Amin * 10000, (int)Amax * 10000)) / 10000;
            return x;
        }

        //public void PoliczWartoscY() {
        //    for (int i = 0; i < n2; i++)
        //    {
        //        y = Generuj(A);
        //        this.wartosciSygnaluY.Add(y);
        //    }
        //} 
        

    }
}
