using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punkt
{
    class Lange
    {
        public int a;
        public int b;
        public double lange;
        public Punktcord P;
        public Punktcord B;

        public Lange(Punktcord p, Punktcord b)
        {
            P = p;
            B = b;
        }

        public void  LangevonPunkterechnen(Punktcord P,Punktcord B)
        {
            a = P.xco - B.xco;
            b = P.yco - B.yco;
            Console.WriteLine($" a = {a} , b = {b}");
             lange= Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Die länge ist  c = {0}",Math.Round(lange));

        }
    }
}
