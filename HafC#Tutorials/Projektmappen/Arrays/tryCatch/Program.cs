using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, erg;
            bool check;

            Console.WriteLine("Divisions-Automat");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            //Eingabe 1. Zahl
            do
            {
                try
                {
                    Console.WriteLine("Bitte 1. Zahl eingeben:");
                    a = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    Console.WriteLine("Bitte nur ganze Zahlen eingeben.");
                    check = false;
                }
            } while (!check);

            //Eingabe 2. Zahl
            do
            {
                try
                {
                    Console.WriteLine("Bitte 2. Zahl eingeben:");
                    b = Convert.ToInt32(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    Console.WriteLine("Bitte nur ganze Zahlen eingeben.");
                    check = false;
                }
            } while (!check);

            //Berechnugs-Versuch
            try
            {
                erg = a / b;
                Console.WriteLine("Das Ergebnis von {0} dividiert durch {1} ist {2}.", a, b, erg);
            }
            catch
            {
                Console.WriteLine("Keine Division durch 0 möglich.");
            }



            Console.ReadKey();
        }
    }
}
