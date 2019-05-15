using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieErsteVererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug f1 = new Fahrzeug();
            //f1.fahrer = true;
            f1.maxGeschw = 50.2;

            Console.WriteLine($"Fahrzeug: Fahrer = {f1.fahrer} / MaxGeschwindigkeit: {f1.maxGeschw}" +
                $" Fuß/Stunde");

            PKW p1 = new PKW();
            p1.motor = "8-Zylinder";
            p1.anzahlTueren = 5;
            p1.maxGeschw = 52.3;
            //p1.fahrer = false;

            Beispielklasse b1 = new Beispielklasse();
            b1.a = 42;
            Beispielklasse b2 = new Beispielklasse();
            b2.a = 7;

            b1.NichtStatisch();
            b2.NichtStatisch();
            Beispielklasse.Statisch();

            Console.ReadKey();
        }
    }
}
