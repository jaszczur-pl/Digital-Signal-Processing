using System;
using System.Collections.Generic;

namespace CPS
{
    public abstract class Sygnal
    {
        public double A { get; set; }
        public double t1 { get; set; }
        public double d { get; set; }
        public double T { get; set; } 
        public double kw { get; set; }
        public double ts { get; set; }
        public double n1 { get; set; }
        public double ns { get; set; }
        public double f { get; set; }
        public double p { get; set; }

        public int iloscPrzedzialowHistogramu { get; set; }

        public List<double> axisY = new List<double>();
        public List<double> axisX = new List<double>();
        protected const int numberOfSamples = 10000;

        //public abstract void PoliczWartoscY();
        //public abstract double wartoscSrednia(List<double> lista);
        //public abstract double wartośćSredniaBezwzgledna(List<double> lista);
        //public abstract double mocSrednia(List<double> lista);
        //public abstract double wariancja(List<double> lista);
        //public abstract double wartoscSkuteczna(List<double> lista);

        public List<double> Dodawanie(List<double> lista1, List<double> lista2)
        {
            int dlugosc =Math.Max(lista1.Count, lista2.Count);
            List<double> sumaSygnalow = new List<double>();
            for(int i = 0; i < dlugosc; i++)
            {
                sumaSygnalow[i] = lista1[i] + lista2[i];
            }
            return sumaSygnalow;
        }

        public List<double> Odejmowanie(List<double> lista1, List<double> lista2)
        {
            int dlugosc = Math.Max(lista1.Count, lista2.Count);
            List<double> roznicaSygnalow = new List<double>();
            for (int i = 0; i < dlugosc; i++)
            {
                roznicaSygnalow[i] = lista1[i] - lista2[i];
            }
            return roznicaSygnalow;
        }

        public List<double> Mnozenie(List<double> lista1, List<double> lista2)
        {
            int dlugosc = Math.Max(lista1.Count, lista2.Count);
            List<double> iloczynSygnalow = new List<double>();
            for (int i = 0; i < dlugosc; i++)
            {
                iloczynSygnalow[i] = lista1[i] * lista2[i];
            }
            return iloczynSygnalow;
        }

        public List<double> Dzielenie(List<double> lista1, List<double> lista2)
        {
            int dlugosc = Math.Max(lista1.Count, lista2.Count);
            List<double> ilorazSygnalow = new List<double>();
            for (int i = 0; i < dlugosc; i++)
            {
                ilorazSygnalow[i] = lista1[i] * lista2[i];
            }
            return ilorazSygnalow;
        }

        public void Histogram(List<double> lista)
        {
            double[,] hist = new double[2, iloscPrzedzialowHistogramu];
            lista.Sort();
            double przedzialHistogramu = A / iloscPrzedzialowHistogramu;
            int j = 0;
            for (int i =0; i < iloscPrzedzialowHistogramu; i++)
            {
                hist[0, i] =i * przedzialHistogramu;
                int ilosc = 0;
                
                while(lista[j]>=hist[0,i] && lista[j]<hist[0,i]+przedzialHistogramu)
                {
                    ilosc++;
                    j++;
                }
                hist[1, i] = ilosc;
            }
        }



    }
}