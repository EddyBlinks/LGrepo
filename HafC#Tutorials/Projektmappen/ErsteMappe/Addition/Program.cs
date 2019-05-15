using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            double ersteZahl, zweiteZahl, summe;
            bool eingabeBool;

            //Eingabe der ersten Zahl
            Console.WriteLine("Bitte erste Zahl eingeben:");
            eingabeBool = double.TryParse(Console.ReadLine(), out ersteZahl);

            if(eingabeBool == false)
            {
                Console.WriteLine("Fehleingabe! Bitte überprüfen.");
            }

            //ersteZahl = double.Parse(Console.ReadLine());
            Console.WriteLine();


            //Eingabe der zweiten Zahl
            Console.WriteLine("Bitte zweite Zahl eingeben:");
            eingabeBool = double.TryParse(Console.ReadLine(), out zweiteZahl);

            if(eingabeBool == false)
            {
                Console.WriteLine("Fehleingabe! Bitte überprüfen.");
            }

            Console.WriteLine();

            //Ausgabe
            summe = ersteZahl + zweiteZahl;
            Console.WriteLine(ersteZahl + " + " + zweiteZahl + " = " + summe);
            Console.WriteLine("Das Ergebnis ist: " + summe);

            Console.ReadKey();
        }
    }
}
