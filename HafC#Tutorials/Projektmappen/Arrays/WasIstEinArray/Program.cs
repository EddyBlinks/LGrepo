using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasIstEinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1, zahl2, zahl3, zahl4, zahl5;

            zahl1 = 1;
            zahl2 = 2;
            zahl3 = 3;
            zahl4 = 4;
            zahl5 = 5;

            int[] intArray = new int[5];

            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;
            intArray[4] = 5;

            Console.WriteLine(zahl3);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[1] + intArray[4]);

            string[] strArray = new string[2];
            strArray[0] = "Hello ";
            strArray[1] = "World!";

            string ausgabe = strArray[0] + strArray[1];
            Console.WriteLine(ausgabe);

            Console.WriteLine("------------------------------------");

            double[] douArray = new double[6] { 2.1, 5, 8, 34.789, 34.7, 13 };
            float[] flArray = { 2.3f, 5, 8 };

            int[] grosserArray = new int[350000];

            Console.WriteLine(grosserArray.Length);

            string abc = "";
            abc = null;

            //Random rnd = new Random();

            //for (int i = 0; i < grosserArray.Length; i++)
            //{
            //    grosserArray[i] = rnd.Next(0,1000001);
            //}

            foreach (int item in grosserArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
