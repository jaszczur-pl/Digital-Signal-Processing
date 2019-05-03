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

            Sygnal quantizedSingal = new Sygnal();
            quantizedSingal.f = frequency;

            for (double i = signal.ts; i <= signal.ts + signal.d; i += 1 / frequency) {
                quantizedSingal.axisX.Add(i);

                
                //quantizedSingal.axisY.Add();
            }

            return quantizedSingal;
        }
    }
}
