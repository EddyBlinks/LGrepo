using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EigenschaftenBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.vorname = "Frank N.";
            p1.nachname = "Stein";

            Konto k1 = new Konto();
            k1.inhaber = p1;
            k1.kontonr = 5;
            //k1.kontostand = 5.20m;

            k1.Einzahlen(200.50m);
            k1.Abheben(50.10m);
            k1.KontostandAnzeigen();

            //k1.kontostand = 10000000;

            Console.WriteLine(k1.Kontostand);

            Console.WriteLine("---------------------");
            k1.Kontostand = 10000000;
            Console.WriteLine(k1.Kontostand);

            k1.Kontostand = k1.Kontostand + 0.50m;
            Console.WriteLine(k1.Kontostand);

            k1.KontostandAnzeigen();

            Console.ReadKey();
        }
    }
}
