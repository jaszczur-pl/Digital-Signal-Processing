using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    public class Sygnal
    {
        int A; //amplituda
        int t1; // czas poczatkowy
        int d; // czas trwania
        int t2 = t1 + d; //czas koncowy
        int n; //numer probki
        double T; //okres
        double f = 1 / T; // czestotliwosc

    }
}
