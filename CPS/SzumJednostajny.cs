using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class SzumJednostajny : SCiagly
    {
        float y;

        public SzumJednostajny(int A, int T, double kw) : base(A, T, kw)
        {

        }

        public float Generuj(int A)
        {
            int Amin = (A/2 * -1);
            int Amax = A/2;
            
            Random r = new Random(System.DateTime.Now.Millisecond);
            float x = (r.Next(Amin * 10000, Amax * 10000)) / 10000;
            return x;
        }
        public void PoliczWartoscY() {
            for (int i = 0; i < n; i++)
            {
                y = Generuj(A);
                this.wartosciSygnaluY.Add(y);
            }
        } 
        

    }
}
