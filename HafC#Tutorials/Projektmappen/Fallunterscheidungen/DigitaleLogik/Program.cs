using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaleLogik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            bool test;

            test = true && true;
            Console.WriteLine(test);

            test = !(a < 10) && a == 10;
            Console.WriteLine(test);

            test = a < b || b > 15;
            Console.WriteLine(test);

            test = a == 10 ^ b == 21;
            Console.WriteLine(test);

            Console.ReadKey();
        }
    }
}
