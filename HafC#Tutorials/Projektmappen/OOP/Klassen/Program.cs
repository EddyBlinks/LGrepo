using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            PKW p1 = new PKW();
            p1.farbe = "weiss";
            p1.anzahlTueren = 5;
            p1.ps = 180;
            p1.klimaAnlage = true;

            p1.Ausgabe();
            

            PKW p2 = new PKW();
            p2.farbe = "rot";
            p2.anzahlTueren = 3;
            p2.ps = 55;
            p2.klimaAnlage = false;

            p2.Ausgabe();

            PKW.StatischeMethode();

            Console.ReadLine();
        }
    }

    class PKW
    {
        public string farbe;
        public sbyte anzahlTueren;
        public int ps;
        public bool klimaAnlage;

        public void Ausgabe()
        {
            Console.Write("Mein Auto hat die Farbe {0}, besitzt {1} Türen und hat {2}" +
                " PS.", farbe, anzahlTueren, ps);
            if (klimaAnlage == true)
            {
                Console.WriteLine("Ebenso besitzt der PKW eine Klimaanlage.");
            }
            Console.WriteLine();
        }

        public static void StatischeMethode()
        {
            Console.WriteLine("Ich bin eine statische Methode.");
        }
    }
}
