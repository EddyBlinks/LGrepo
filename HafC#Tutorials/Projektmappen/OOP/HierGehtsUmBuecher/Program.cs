using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierGehtsUmBuecher
{
    class Program
    {
        static void Main(string[] args)
        {
            Buch buch1 = new Buch("1111-111-111-11", "Vom Winde verweht", 
                new Autor("Max", "Musterautor", new DateTime(1800,1,22), new DateTime(1850, 5, 5)) 
                , false);
            Buch buch2 = new Buch("222-222-22-222-2", "Christliches Kochbuch",
                new Autor("Un", "known", new DateTime(1820,6,2), new DateTime(1830, 7,7))
                , true);
            Buch buch3 = new Buch("333-333-3-3-3-333", "Herr der Ringe", 
                new Autor("J.R.R.", "Tolkien", new DateTime(1892, 1,3), new DateTime(1973, 9,2))
                , false);

            Buecherei buech1 = new Buecherei("Altes Buch", "Karlsruhe",
                buch1, buch2, buch3);

            //Buecherei buech2 = new Buecherei("Neues Buch", "Monnem",
            //    new Buch("444-444-444-444", "Reise zum Mond", "Jules Verne", true),
            //    buch2, new Buch("555-555-555-555", "Mittelpunkt der Erde", "Jules Verne", false));

            buech1.b1.Ausgabe();
            Console.WriteLine(buech1.b2.autor.gebDat.ToShortDateString());

            //buech2.b3.Ausgabe();

            Console.WriteLine("--------------------------");

            //DateTime dat = new DateTime(1899, 7, 21);
            //Console.WriteLine(dat.ToShortDateString());

            Autor a1 = new Autor("Jules", "Verne", new DateTime(1828, 2, 8),
                new DateTime(1905, 3, 24));

            Console.WriteLine($"Name des Autors: {a1.vorname} {a1.nachname}");
            Console.WriteLine("Geburtsdatum: " + a1.gebDat.ToShortDateString());
            Console.WriteLine("Todestag: {0}", a1.sterbDat.ToShortDateString());

            

            Console.ReadKey();
        }
    }
}
