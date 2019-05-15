using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehrfacheFallunterscheidung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Eingabe: ");
            string eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    Console.WriteLine("Sie haben die '1' eingegeben.");
                    break;
                case "2":
                    Console.WriteLine("Sie haben die '2' eingegeben.");
                    break;
                case "3":
                    Console.WriteLine("Sie haben die '3' eingegeben.");
                    break;
                case "4":
                    Console.WriteLine("Sie haben die '4' eingegeben.");
                    break;
                default:
                    Console.WriteLine("Keine korrekte Eingabe.");
                    break;
            }

            Console.WriteLine("-------------------------------");

            if (eingabe == "1")
            {
                Console.WriteLine("Sie haben die '1' eingegeben.");
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Sie haben die '2' eingegeben.");
            }
            else if (eingabe == "3")
            {
                Console.WriteLine("Sie haben die '3' eingegeben.");
            }
            else if (eingabe == "4")
            {
                Console.WriteLine("Sie haben die '4' eingegeben.");
            }
            else
            {
                Console.WriteLine("Falsche Eingabe.");
            }

            Console.ReadKey();
        }
    }
}
