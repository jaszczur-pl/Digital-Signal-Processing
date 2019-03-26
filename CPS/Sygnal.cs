namespace CPS
{
    public class Sygnal
    {
        public int A { get; set; }
        public static int t1 = 0;
        public static int d = 1;
        public int n = 1000;
        public double T { get; set; }

        public int t2 = t1 + d; //czas koncowy

        public Sygnal(int A, double T)
        {
            this.A = A;
            this.T = T;
        }
    }
}