using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussgesteuert
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 77;

            do
            {
                Console.WriteLine("Schleife ausgeführt: " + zahl);
                zahl = zahl + 1;
            } while (zahl < 50);


            Console.ReadKey();
        }
    }
}
