using System;
using System.Collections.Generic;

namespace CPS
{
    public class Sygnal {

        public Sygnal() {
            IsDiscreteSignal = false;
        }
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

        public virtual void CalculateXYPoints() { }
        //public abstract double wartoscSrednia(List<double> lista);
        //public abstract double wartośćSredniaBezwzgledna(List<double> lista);
        //public abstract double mocSrednia(List<double> lista);
        //public abstract double wariancja(List<double> lista);
        //public abstract double wartoscSkuteczna(List<double> lista);
    }
}