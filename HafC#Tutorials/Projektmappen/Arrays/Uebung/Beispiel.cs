using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{
    class Beispiel
    {

        static public void Ausgabe()
        {
            Console.WriteLine("Methode");
        }

        static public void Ausgabe2()
        {
            Ausgabe();
            Console.WriteLine("Methode2");
        }
    }
}
