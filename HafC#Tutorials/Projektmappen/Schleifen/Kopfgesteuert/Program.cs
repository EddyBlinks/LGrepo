using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopfgesteuert
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0;

            while (zahl < 20)
            {
                Console.WriteLine("Schleife Nr: " + zahl);
                zahl = zahl + 1;
            }

            Console.ReadKey();
        }
    }
}
