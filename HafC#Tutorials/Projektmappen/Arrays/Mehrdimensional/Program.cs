using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehrdimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //2-dimensionaler Array
            int[,] zweiDim = new int[2, 3];
            zweiDim[0, 0] = 5;
            zweiDim[0, 1] = 8;
            zweiDim[0, 2] = 13;
            zweiDim[1, 0] = 4;
            zweiDim[1, 1] = 98;
            zweiDim[1, 2] = 5;

            foreach (int item in zweiDim)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(zweiDim.GetUpperBound(1));

            //3-dimensionaler Array
            int[,,] dreiDim = new int[2, 2, 2];
            dreiDim[0, 0, 0] = 15;
            dreiDim[0, 0, 1] = 27;

            Console.WriteLine("------------------------");

            //Lenght vs UpperBound

            int[] derArray = { 1, 2, 3, 4 };
            int[] derArray2 = { 10, 20, 30 };
            int[] derArray3 = new int[4];


            //Console.WriteLine(derArray.Length);
            //Console.WriteLine(derArray.GetUpperBound(0));
            //derArray[2] = derArray[0] + derArray[3];

            Console.ReadKey();
        }
    }
}
