using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstDasEinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hallo";
            char[] text2 = new char[] { 'H', 'a', 'l', 'l', 'o' };

            Console.WriteLine(text);

            foreach (char item in text2)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            foreach (char item in text)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine(text[0]);

            

            Console.ReadKey();
        }
    }
}
