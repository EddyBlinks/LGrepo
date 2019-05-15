using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerName
{
    class Program
    {
        static void Main(string[] args)
        {
            string vorname, nachname, alter, haarfarbe, gesamtName;

            //Eingabe des Vornamens
            Console.WriteLine("Bitte geben Sie Ihren Vornamen ein:");
            vorname = Console.ReadLine();
            Console.WriteLine();

            //Eingabe des Nachnamens
            Console.WriteLine("Bitte geben Sie Ihren Nachnamen ein:");
            nachname = Console.ReadLine();
            Console.WriteLine();

            //Eingabe des Alters
            Console.WriteLine("Bitte geben Sie Ihr Alter an:");
            alter = Console.ReadLine();
            Console.WriteLine();

            //Eingabe der Haarfarbe
            Console.WriteLine("Bitte geben Sie Ihre \"echte\" Haarfarbe ein:");
            haarfarbe = Console.ReadLine();
            Console.WriteLine();

            //Ausgabe
            gesamtName = vorname + " " + nachname;
            Console.WriteLine("Ihr Name ist: " + gesamtName);
            Console.WriteLine("Sie sind " + alter + " Jahre alt.");
            Console.WriteLine("Ihre \"wirklich\" echte Haarfarbe ist: " + haarfarbe);

            Console.ReadKey();
        }
    }
}
