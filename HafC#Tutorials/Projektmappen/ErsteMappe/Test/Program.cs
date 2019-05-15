using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 8;

            if(a == 10)
            {
                if (b > a)
                {
                    Console.WriteLine("Trifft zu!");
                }
            }

            if (a > b)
            {
                Console.WriteLine("a > b");
            }

            if (b > a)
            {

            }
            
            
            

            Console.ReadKey();
        }
    }
}
