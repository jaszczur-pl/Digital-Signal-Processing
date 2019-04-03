﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalSinWyprostowanyDwuPolowkowo:SygnalSin
    {
        double y;
        public SygnalSinWyprostowanyDwuPolowkowo(int A, double T, double kw) : base(A, T, kw)
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