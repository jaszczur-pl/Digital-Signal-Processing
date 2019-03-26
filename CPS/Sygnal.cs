namespace CPS
{
    public class Sygnal
    {
        public int A { get; set; }
        public static int t1 = 0;
        public static int d = 1;
        public int n { get; set; }
        public static double T { get; set; }

        int t2 = t1 + d; //czas koncowy
        double f = 1 / T; // czestotliwosc

    }
}