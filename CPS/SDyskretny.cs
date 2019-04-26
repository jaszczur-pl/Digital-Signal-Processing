using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SDyskretny : Sygnal
    {

        //public override double mocSrednia(List<double> lista)
        //{
        //    double mS = 0;
        //    for (int i = n1; i < n2; i++)
        //    {
        //        mS = mS + Math.Pow(lista[i], 2);
        //    }
        //    mS = 1 / (n2 - n1 + 1) * mS;
        //    return mS;
        //}

        //public override void CalculateXYPoints()
        //{
        //    throw new NotImplementedException();
        //}

        //public override double wariancja(List<double> lista)
        //{
        //    double wariancja = 0;
        //    for (int i = n1; i < n2; i++)
        //    {
        //        wariancja = wariancja + Math.Pow(lista[i] - wartoscSrednia(lista), 2);
        //    }
        //    wariancja = 1 / (n2 - n1 + 1) * wariancja;
        //    return wariancja;
        //}

        //public override double wartoscSkuteczna(List<double> lista)
        //{
        //    double wSkuteczna = 0;
        //    for (int i = n1; i < n2; i++)
        //    {
        //        wSkuteczna = wSkuteczna + Math.Pow(lista[i], 2);
        //    }
        //    wSkuteczna = Math.Sqrt(1 / (n2 - n1 + 1) * wSkuteczna);
        //    return wSkuteczna;
        //}

        //public override double wartoscSrednia(List<double> lista)
        //{
        //    double srednia = 0;
        //    for (int i = n1; i < n2; i++)
        //    {
        //        srednia = srednia + lista[i];
        //    }
        //    srednia = srednia / n2;
        //    return srednia;
        //}

        //public override double wartośćSredniaBezwzgledna(List<double> lista)
        //{
        //    double srednia = 0;
        //    for (int i = n1; i < n2; i++)
        //    {
        //        srednia = srednia + Math.Abs(lista[i]);
        //    }
        //    srednia = srednia / n2;
        //    return srednia;
        //}
    }
}
