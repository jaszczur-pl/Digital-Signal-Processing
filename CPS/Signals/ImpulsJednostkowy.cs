using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class ImpulsJednostkowy: Sygnal
    {
        public ImpulsJednostkowy(double A, double n1, double ns, double d, double f)
        {
            this.A = A;
            this.n1 = n1;
            this.ns = ns;
            this.d = d;
            this.f = f;
        }

        //public void ObliczWartoscY()
        //{
        //    double t;
        //    int y;
        //    for (int i = 0; i < n2; i++)
        //    {
        //        t = i * k;
        //        if (t== 0)
        //        {
        //            y = A;
        //        }
        //        else
        //        {
        //            y = 0;
        //        }
        //        this.axisY.Add(y);
        //    }
        //}
    }
}
