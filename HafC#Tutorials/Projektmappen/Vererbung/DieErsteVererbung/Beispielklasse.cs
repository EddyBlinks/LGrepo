using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieErsteVererbung
{
    class Beispielklasse
    {
        public int a;

        public void NichtStatisch()
        {
            Console.WriteLine(a);
        }

        public static void Statisch()
        {
            Console.WriteLine("Statisch");
        }
    }
}
