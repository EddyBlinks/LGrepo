using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmetischeOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration & Initialisierung
            int zahl1 = 10, zahl2 = 25;
            int zahl3;

            zahl3 = zahl1 + zahl2;
            Console.WriteLine(zahl3);

            zahl3 = zahl1 - zahl2;      // Wert: -15
            Console.WriteLine(zahl3);

            zahl3 = zahl3 + 20;
            Console.WriteLine(zahl3);

            zahl3 = zahl1 * zahl2;
            Console.WriteLine(zahl3);

            zahl3 = zahl1 / zahl2;
            Console.WriteLine(zahl3);

            //Modulo
            zahl3 = zahl2 % zahl1;
            Console.WriteLine(zahl3);

            //
            zahl3 = 10 + 18;
            //zahl3 = zahl1 / 0;      //Teilung durch 0 (nicht möglich)
            Console.WriteLine(zahl3);

            Console.WriteLine("---------------------------------");

            string zeichen1, zeichen2, zeichen3;

            zeichen1 = "Hallo";
            zeichen2 = " Welt!";
            zeichen3 = zeichen1 + zeichen2;
            Console.WriteLine(zeichen3);

            Console.WriteLine("--------------------");

            char symbol1 = 'c', symbol2 = 'z';
            string symbol3;

            symbol3 = symbol1.ToString() + symbol2.ToString();

            Console.WriteLine(symbol3);

            Console.WriteLine("--------------------");

            int a = 10, b = 25;
            double c;

            c = (double)a / (double)b;
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
