using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SignalFilter
    {
        public Sygnal MakeConvolution(Sygnal signal1, Sygnal signal2) {

            Sygnal convolutedSignal = new Sygnal();
            convolutedSignal.IsDiscreteSignal = true;

            int numberOfElements = signal1.axisX.Count + signal2.axisX.Count - 1;

            for (int i=0; i < numberOfElements; i++) {
                double sum = 0;

                for (int k=0; k < signal1.axisX.Count - 1; k++) {

                    if (i - k >= 0 && i - k < signal2.axisX.Count) {
                        sum += signal1.axisY[k] * signal2.axisY[i - k];
                    }

                }
                convolutedSignal.axisX.Add(i);
                convolutedSignal.axisY.Add(sum);

            }

            return convolutedSignal;
        }
    }
}
