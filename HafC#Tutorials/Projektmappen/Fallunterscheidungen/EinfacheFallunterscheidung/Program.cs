using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacheFallunterscheidung
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 7;

            //Einfache Fallunterscheidung
            if (zahl > 7)
            {
                Console.WriteLine("Zahl ist grösser als 7");
            }
            else
            {
                Console.WriteLine("Zahl ist kleiner oder gleich als 7");
            }

            Console.WriteLine("Programmende");

            Console.ReadKey();
        }
    }
}
