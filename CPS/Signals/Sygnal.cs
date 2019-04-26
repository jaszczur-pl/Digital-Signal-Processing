using System;
using System.Collections.Generic;

namespace CPS
{
    [Serializable]
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
        public bool IsDiscreteSignal { get; set; }

        public List<double> axisY = new List<double>();
        public List<double> axisX = new List<double>();

        public double AverageValue { get; set; }
        public double AbsAverageValue { get; set; }
        public double RMS { get; set; }
        public double Variance { get; set; }
        public double AveragePower { get; set; }

        protected const int numberOfSamples = 10000;
        



        public virtual void CalculateXYPoints() { }
    }
}