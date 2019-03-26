namespace CPS
{
    public class Sygnal
    {
        public int A { get => A; set => A = value; }
        public int t1 { get => t1; set => t1 = value; }
        public int d { get => d; set => d = value; }
        public int n { get => n; set => n = value; }
        public double T { get => t; set => t = value; }

        int t2 = t1 + d; //czas koncowy
        int n; //numer probki
        double f = 1 / T; // czestotliwosc

    }
}