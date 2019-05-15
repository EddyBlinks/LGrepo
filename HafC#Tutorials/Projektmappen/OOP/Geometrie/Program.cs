using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test-Punkt
            //Punkt p1 = new Punkt(7, 9);

            //Console.WriteLine(p1.KoordinatenAusgabe());

            //Console.WriteLine("--------------------");

            //Linie
            Linie l1 = new Linie(new Punkt(5.2, 9.6), new Punkt(4.7, 8.9));

            Console.WriteLine(l1.LaengeLinie());
            Console.WriteLine(l1.p1.KoordinatenAusgabe());
            Console.WriteLine(l1.p2.KoordinatenAusgabe());

            Console.WriteLine("-----------------------");

            //Rechteck
            Rechteck r1 = new Rechteck(new Punkt(5,2), new Punkt(8,6));
            r1.AusgabeRechteck();

            Console.ReadKey();
        }
    }
}
