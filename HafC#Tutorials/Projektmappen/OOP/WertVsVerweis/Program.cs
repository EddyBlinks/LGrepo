using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WertVsVerweis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b;
            b = a;
            b = 12;
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine("--------------------");

            Beispiel b1 = new Beispiel();
            b1.name = "Der Name";
            b1.anzahl = 5;

            Beispiel b2 = new Beispiel();

            b2 = b1;

            //Console.WriteLine(b2.name);
            //Console.WriteLine(b2.anzahl);

            b2.name = "auto";
            b2.anzahl = 13;

            Console.WriteLine(b1.name);
            Console.WriteLine(b1.anzahl);

            Console.ReadKey();
        }
    }
}
