using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodenueberladung
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            double b = 13.7;
            double erg;

            erg = Addieren(b, a);
            Console.WriteLine(erg);



            Console.ReadKey();
        }

        static int Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        static double Addieren(double zahl1, double zahl2)
        {
            return zahl1 + zahl2;
        }

        static double Addieren(double zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }
    }
}
