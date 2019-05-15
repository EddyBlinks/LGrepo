using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl = Math.PI;

            Console.WriteLine(Math.Round(zahl, 2));

            Console.ReadKey();
        }
    }
}
