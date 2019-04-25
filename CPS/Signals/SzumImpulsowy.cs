using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SzumImpulsowy:SDyskretny
    {
        double y;
        double p;

        public SzumImpulsowy(double A, double t1, double d, double f , double p)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            this.f = f;
            this.p = p;
        }

        //public float Generuj()
        //{
        //    Random r = new Random(System.DateTime.Now.Millisecond);
        //    float x = (r.Next(0, 1000000)) / 1000000;
        //    return x;
        //}

        //public void PoliczWartoscY()
        //{
        //    for (int i = 0; i < n2; i++)
        //    {
        //        p = Generuj();
        //        if (p >= P)
        //        {
        //            y = A;
        //        }
        //        else
        //        {
        //            y = 0;
        //        }
        //        this.wartosciSygnaluY.Add(y);
        //    }
        //}

    }
}
