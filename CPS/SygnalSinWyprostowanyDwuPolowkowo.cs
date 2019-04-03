using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalSinWyprostowanyDwuPolowkowo:SygnalSin
    {
        double y;
        public SygnalSinWyprostowanyDwuPolowkowo(int A, int T) : base(A, T)
        {

        }

        public new void PoliczWartoscY()
        {
            for (int i = 0; i < n; i++)
            {
                if (FSin(T, i) < 0)
                {
                    y =A*(-1 * FSin(T, i));
                }
                else
                {
                    y = A*FSin(T, i);
                }
                this.wartosciSygnaluY.Add(y);
            }
        }
    }
}