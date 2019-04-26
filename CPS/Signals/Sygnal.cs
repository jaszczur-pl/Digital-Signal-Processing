using System;
using System.Collections.Generic;

namespace CPS
{
    public abstract class Sygnal {
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

        public string signalName { get; set; }

        public List<double> axisY = new List<double>();
        public List<double> axisX = new List<double>();
        protected const int numberOfSamples = 10000;
        public bool IsDiscreteSignal {get; set;}

        public abstract void CalculateXYPoints();
        //public abstract double wartoscSrednia(List<double> lista);
        //public abstract double wartośćSredniaBezwzgledna(List<double> lista);
        //public abstract double mocSrednia(List<double> lista);
        //public abstract double wariancja(List<double> lista);
        //public abstract double wartoscSkuteczna(List<double> lista);

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