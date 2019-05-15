using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Zähler: " + i);
                }
            }

            Console.WriteLine("-----------------------");

            for (int i = 1; i <= 20; i++)
            {
                if (i % 5 != 0)
                {
                    continue;
                }

                Console.WriteLine("Zähler: " + i);
            }

            Console.WriteLine("-----------------");

            for (int i = 0; i < 20; i++)
            {
                if (i > 10)
                {
                    break;
                }

                Console.WriteLine("Zähler: " + i);
            }

            Console.ReadLine();
        }
    }
}
