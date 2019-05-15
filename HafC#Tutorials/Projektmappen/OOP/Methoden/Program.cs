using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    class Program
    {
        static void Addieren(int a, int b)
        {
            int erg = a + b;
            Console.WriteLine(erg);
        }

        static void Main(string[] args)
        {
            Auswahlmenue();

            //viel Code...
            Console.WriteLine("------------------------------");

            int zahl1 = 10;
            int zahl2 = 12;
            int erg;

            //Addieren ohne Rückgabewert
            Addieren(5, 13);
            Addieren(zahl1, zahl2);

            //Addieren mit Rückgabewert
            erg = AddierenMitRueckgabe(zahl1, zahl2);
            Console.WriteLine("Ergebnis: " + erg);

            //Out-Schlüsselwort
            AddierenOut(zahl1, zahl2, out erg);



            Console.ReadKey();
        }

        static void Auswahlmenue()
        {
            Console.WriteLine("(A)ddieren");
            Console.WriteLine("(S)ubtrahieren");
            Console.WriteLine("(M)ultiplizieren");
            Console.WriteLine("(D)ividieren");
        }

        static int AddierenMitRueckgabe(int zahlD, int zahlE)
        {
            return zahlD + zahlE;
        }

        static void AddierenOut(int a, int b, out int c)
        {
            c = a + b;
        }
    }
}
