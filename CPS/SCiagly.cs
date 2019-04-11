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

        public void PelneOkresy(List<double> lista)
        {   if (T != 0)
            {
                if (d % T != 0)
                {
                    double tPelnychOkresow = (int)(d / T) * T;
                    int nPelnychOkresow = (int)(tPelnychOkresow / k);
                    lista.RemoveRange(nPelnychOkresow, lista.Count - nPelnychOkresow);
                    /*while (lista.Count > nPelnychOkresow)
                    {
                        lista.RemoveAt(lista.Count-1);
                    }*/
                }
            }
        }

        public override double mocSrednia(List<double> lista)
        {
            PelneOkresy(lista);
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
            PelneOkresy(lista);
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
            PelneOkresy(lista);
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
            PelneOkresy(lista);
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
            PelneOkresy(lista);
            double srednia = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                srednia = srednia + Math.Abs(lista[i]*k);
            }
            srednia = srednia / lista.Count;
            return srednia;
        }

        public override void PoliczWartoscY()
        {
            throw new NotImplementedException();
        }
    }
}
