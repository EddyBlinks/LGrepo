using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[3] { "Ich", "habe", "braunes Haar" };
            string[] strArray2 = new string[2] { "Alter", "zu alt"};

            string[][] jaggedArray = new string[2][];
            jaggedArray[0] = strArray;
            jaggedArray[1] = strArray2;

            Console.WriteLine(jaggedArray[0][2]);
            Console.WriteLine(jaggedArray[1][1]);

            Console.ReadKey();
        }
    }
}
