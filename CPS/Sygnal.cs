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

        public int t2 = t1 + d; //czas koncowy

        public Sygnal(int A, double T, double kw)
        {
            this.A = A;
            this.T = T;
            this.kw = kw;
        }

        public abstract double wartoscSrednia(List<double> lista);
        public abstract double wartośćSredniaBezwzgledna(List<double> lista);
        public abstract double mocSrednia(List<double> lista);
        public abstract double wariancja(List<double> lista);
        public abstract double wartoscSkuteczna(List<double> lista);

    }
}