using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErstesProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hallo");
            Console.WriteLine(" Hallo2");

            //Deklaration
            int zahlInt;
            string zeichenKette;

            //Initialisieren
            zahlInt = 42;
            zeichenKette = "Ein Wort";

            //Deklaration & Initialisierung
            char einChar = 'a';
            string einZeichen = "42";

            //Numerischen Datentypen(Ganzzahl) - signed
            short zahlShort = 335;
            long zahlLong = 111111111111111111;
            sbyte zahlSByte = -100;

            //Numerische Datentypen(Ganzzahl) - unsigned
            byte zahlByte = 100;
            uint zahlUInt = 4253151;

            //Numerischen Datentypen (Gleitkommazahl)
            float zahlFloat = 5.326f;
            double zahlDouble = 5.63698;
            decimal zahlDecimal = 45321.2354m;

            //Bool'scher Datentyp
            bool wertBool = true;
            bool wertBool2 = false;


            Console.WriteLine(zahlInt);
            Console.WriteLine(zeichenKette);
            Console.WriteLine(einChar);
            Console.WriteLine(zahlFloat);


            Console.ReadKey();
        }
    }
}
