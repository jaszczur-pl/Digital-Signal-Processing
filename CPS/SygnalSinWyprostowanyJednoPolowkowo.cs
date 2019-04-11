using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalSinWyprostowanyJednoPolowkowo: SygnalSin
    {
        double y;
        public SygnalSinWyprostowanyJednoPolowkowo(int A, int T, double kw) : base(A, T, kw)
        {

        }

        public new void PoliczWartoscY()
        {
            for (int i = 0; i < n2; i++)
            {
                if (FSin(T, i) < 0)
                {
                    y =(1/2*A*FSin(T, i)) + (-1 * FSin(T, i));
                }
                else
                {
                    y = (1/2*A*FSin(T, i)) + FSin(T, i);
                }
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}