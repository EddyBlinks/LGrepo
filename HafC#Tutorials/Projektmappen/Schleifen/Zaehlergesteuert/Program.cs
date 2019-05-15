using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaehlergesteuert
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int zaehler = 0; zaehler < 10; zaehler++)
            {
                Console.WriteLine("Schleife Nr: " + zaehler);
            }


            Console.ReadKey();
        }
    }
}
