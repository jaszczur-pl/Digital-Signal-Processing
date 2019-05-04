using System;
using System.Collections.Generic;

namespace CPS
{
    [Serializable]
    public class Sygnal {

        public double A { get; set; } = 0;
        public double t1 { get; set; } = 0;
        public double d { get; set; } = 0;
        public double T { get; set; } = 0;
        public double kw { get; set; } = 0;
        public double ts { get; set; } = 0;
        public double n1 { get; set; } = 0;
        public double ns { get; set; } = 0;
        public double f { get; set; } = 100;
        public double p { get; set; } = 0;
        public int iloscPrzedzialowHistogramu { get; set; }

        public int samplingFrequency { get; set; }
        public int numberOfQuantizationLevels { get; set; }
        public int conversionFrequency { get; set; }

        public string signalName { get; set; }
        public bool IsDiscreteSignal { get; set; } = false;

        public List<double> axisY = new List<double>();
        public List<double> axisX = new List<double>();

        public double AverageValue { get; set; }
        public double AbsAverageValue { get; set; }
        public double RMS { get; set; }
        public double Variance { get; set; }
        public double AveragePower { get; set; }

        //protected const int numberOfSamples = 10000;
        
        public virtual void CalculateXYPoints() { }

        public virtual List<double> CalculateYPoints(List<double> axisX) { return new List<double>(); }

        public virtual Sygnal GetNewSignal() {
            return new Sygnal();
        }
    }
}