using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Bildschirm bild1 = new Bildschirm();
            bild1.farbe = "grau";
            bild1.groesse = 27;
            bild1.aufloesungHoehe = 768;
            bild1.aufloesungBreite = 1024;
            bild1.hertz = 60;

            Bildschirm bild2 = new Bildschirm("Schwarz", 24, 990, 1440, 100);

            Bildschirm bild3 = new Bildschirm(25, 1050, 1680, 120);
            Console.WriteLine(bild3.farbe);

            Bildschirm bild4 = new Bildschirm(24, -1050, 1680, 120);
            Console.WriteLine(bild4.aufloesungHoehe);

            Console.ReadKey();
        }
    }
}
