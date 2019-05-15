using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = new int[6] { 5, 8, 9, 3, 1, 6 };

            foreach (int item in test1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");

            Swap(test1, 1, 3);

            foreach (int item in test1)
            {
                Console.WriteLine(item);
            }

            Beispiel.Ausgabe();

            Console.ReadKey();
        }

        static void Swap(int[] intArr, int zahl1, int zahl2)
        {
            int temp = intArr[zahl1];
            intArr[zahl1] = intArr[zahl2];
            intArr[zahl2] = temp;
        }
    }
}
