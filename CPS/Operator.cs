using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class Operator
    {
        public Sygnal Signal1 { get; set; }
        public Sygnal Signal2 { get; set; }

        public Dictionary<string, List<double>> Dodawanie() {

            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            int xNumber = Signal1.axisX.Count;

            for (int i = 0; i < xNumber; ++i) {
                listX.Add(Signal1.axisX[i]);
                listY.Add(Signal1.axisY[i] + Signal2.axisY[i]);
            }

            dict["X"] = listX;
            dict["Y"] = listY;

            return dict;
        }

        public List<double> Odejmowanie(List<double> lista1, List<double> lista2) {
            int dlugosc = Math.Max(lista1.Count, lista2.Count);
            List<double> roznicaSygnalow = new List<double>();
            for (int i = 0; i < dlugosc; i++) {
                roznicaSygnalow[i] = lista1[i] - lista2[i];
            }
            return roznicaSygnalow;
        }

        public List<double> Mnozenie(List<double> lista1, List<double> lista2) {
            int dlugosc = Math.Max(lista1.Count, lista2.Count);
            List<double> iloczynSygnalow = new List<double>();
            for (int i = 0; i < dlugosc; i++) {
                iloczynSygnalow[i] = lista1[i] * lista2[i];
            }
            return iloczynSygnalow;
        }

        public List<double> Dzielenie(List<double> lista1, List<double> lista2) {
            int dlugosc = Math.Max(lista1.Count, lista2.Count);
            List<double> ilorazSygnalow = new List<double>();
            for (int i = 0; i < dlugosc; i++) {
                ilorazSygnalow[i] = lista1[i] * lista2[i];
            }
            return ilorazSygnalow;
        }
    }
}
