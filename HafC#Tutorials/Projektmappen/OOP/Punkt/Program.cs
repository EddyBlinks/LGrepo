using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punkt
{
    class Program
    {
        static void Main(string[] args)
        {
            Punktcord P = new Punktcord();
            Punktcord B = new Punktcord();
            Console.WriteLine("coordinate von Punkt 1");
            P.Coordinate();
            Console.WriteLine("coordinate von Punkt 2");
            B.Coordinate();
            Lange L = new Lange(P,B);
            L.LangevonPunkterechnen(P, B);
            //Console.WriteLine(L.a);
            //Console.WriteLine(L.b);
            Console.ReadKey();
        }
    }
}
