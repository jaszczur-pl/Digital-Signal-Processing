using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    class SygnalProstokatny:SCiagly
    {
        double y;
        double t;
        public SygnalProstokatny(int A, double T, double kw) : base(A, T, kw)
        {

        }

        public void ObliczWartoscY()
        {
            for (int i = 0; i < n; i++)
            {
                t = i * k;
                if (t>=kw*T+t1 || t<kw)
                {

                }
                this.wartosciSygnaluY.Add(y);
            }
        }

    }
}