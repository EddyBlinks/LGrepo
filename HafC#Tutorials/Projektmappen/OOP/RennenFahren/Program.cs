using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RennenFahren
{
    class Program
    {
        static void Main(string[] args)
        {
            Rennwagen r1 = new Rennwagen(200, 260, 100, 5);
            Rennwagen r2 = new Rennwagen(250, 300, 60 , 2);

            r1.Bremsen(50);
            r2.Bremsen(20);
            Console.WriteLine($"Wagen 1/2 Geschwindigkeit: {r1.aktGeschw}/{r2.aktGeschw}");

            r1.Beschleunigen(200000000);
            r2.Beschleunigen(-100);
            Console.WriteLine($"Wagen 1/2 Geschwindigkeit: {r1.aktGeschw}/{r2.aktGeschw}");

            r1.Stop();
            r2.Beschleunigen(72.3);
            Console.WriteLine($"Wagen 1/2 Geschwindigkeit: {r1.aktGeschw}/{r2.aktGeschw}");


            Console.ReadKey();
        }
    }
}
