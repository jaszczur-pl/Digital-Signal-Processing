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
            for(int i=0; i<lista.Count; i++)
            {
                mS = mS + Math.Pow(lista[i],2)*k;
            }
            mS = 1 / (t2 - t1) * mS;
            return mS;
        }

        public override double wariancja(List<double> lista)
        {
            double wariancja=0;
            for (int i=0; i<lista.Count; i++)
            {
                wariancja = wariancja + Math.Pow(lista[i]*k-wartoscSrednia(lista),2);
            }
            wariancja = 1 / (t2 - t1) * wariancja;
            return wariancja;
        }

        public override double wartoscSkuteczna(List<double> lista)
        {
            double wSkuteczna=0;
            for(int i = 0; i < lista.Count; i++)
            {
                wSkuteczna = wSkuteczna + Math.Pow(lista[i], 2)*k;
            }
            wSkuteczna = Math.Sqrt(1 / (t2 - t1) * wSkuteczna);
            return wSkuteczna;
        }

        public override double wartoscSrednia(List<double> lista)
        {
            double srednia =0;
            for(int i=0; i<lista.Count; i++)
            {
                srednia = srednia + lista[i]*k;
            }
            srednia = srednia / lista.Count;
            return srednia;
        }

        public override double wartośćSredniaBezwzgledna(List<double> lista)
        {
            double srednia = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                srednia = srednia + Math.Abs(lista[i]*k);
            }
            srednia = srednia / lista.Count;
            return srednia;
        }
    }
}
