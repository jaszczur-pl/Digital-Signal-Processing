using System;
using System.Collections.Generic;

namespace CPS
{
    public abstract class Sygnal
    {
        public int A { get; set; } // amplituda
        public const int t1 = 0; // czas poczatkowy
        public const int d = 10; // czas trwania
        public const int n1 = 1; //pierwsza probka
        public const int n2 = 1000; // liczba probek
        public double T { get; set; } //okres
        public const double k = d / n2; //krok
        public List<double> wartosciSygnaluY = new List<double>();
        public double kw { get; set; }// wspolczynnik wypelnienia
        public const double ts = t1 + d / 2;
        public int iloscPrzedzialowHistogramu { get; set; }

        public int t2 = t1 + d; //czas koncowy

        public Sygnal(int A, double T, double kw)
        {
            this.A = A;
            this.T = T;
            this.kw = kw;
        }

        public abstract void PoliczWartoscY();
        public abstract double wartoscSrednia(List<double> lista);
        public abstract double wartośćSredniaBezwzgledna(List<double> lista);
        public abstract double mocSrednia(List<double> lista);
        public abstract double wariancja(List<double> lista);
        public abstract double wartoscSkuteczna(List<double> lista);

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