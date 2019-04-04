using System;
using System.Collections.Generic;

namespace CPS
{
    public class Sygnal
    {
        public int A { get; set; } // amplituda
        public const int t1 = 0; // czas poczatkowy
        public const int d = 10; // czas trwania
        public const int n = 1000; // liczba probek
        public double T { get; set; } //okres
        public const double k = d / n; //krok
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

    }
}