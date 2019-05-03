using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SignalConverter
    {
        public Sygnal EvenSampling(Sygnal signal, double frequency) {

            Sygnal quantizedSignal = new Sygnal();
            quantizedSignal = signal;
            quantizedSignal.f = frequency;

            quantizedSignal.CalculateXYPoints();
            quantizedSignal.signalName = signal.signalName + ", skwantyzowany";


            return quantizedSignal;
        }
    }
}
