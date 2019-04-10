using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SCiagly : Sygnal
    {
    
        public SCiagly(int A, double T, double kw) : base(A, T, kw)
        {

        }

        public override double mocSrednia(List<double> lista)
        {
            double mS=0;
            for(int i=t1; i*k<t2; i++)
            {
                mS = mS + (lista[i]*k);
            }
            mS = 1 / (t2 - t1) * mS;
            return mS;
        }

        public override double wariancja(List<double> lista)
        {

            return 0;
        }

        public override double wartoscSkuteczna(List<double> lista)
        {
            throw new NotImplementedException();
        }

        public override double wartoscSrednia(List<double> lista)
        {
            throw new NotImplementedException();
        }

        public override double wartośćSredniaBezwzgledna(List<double> lista)
        {
            throw new NotImplementedException();
        }
    }
}
