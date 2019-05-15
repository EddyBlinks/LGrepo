using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe1

            //int a;

            //Console.WriteLine("Bitte geben Sie die Länge des Arrays ein:");
            //a = int.Parse(Console.ReadLine());

            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    intArray[i] = i + 1;
            //}

            foreach (int zwischenspeicher in intArray)
            {
                Console.WriteLine("Zähler: " + zwischenspeicher);
            }

            Console.WriteLine("----------------------------------------");

            //Aufgabe2

            int[] intArray2 = new int[10];

            for (int i = 50; i < 60; i++)
            {
                intArray2[i - 50] = i;
            }

            foreach (int item in intArray2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            //Aufgabe3
            int[] intArray3 = new int[10];

            for (int i = 99; i > 89; i--)
            {
                intArray3[i - 90] = i;
            }

            foreach (int item in intArray3)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
