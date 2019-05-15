using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsereHighscore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test der AusgabeHighscore
            //Highscore h1 = new Highscore(896, s1);
            //h1.AusgabeHighscore();

            //Spieler erstellen
            Spieler s1 = new Spieler("AlTeR1536", new DateTime(1991, 1, 1));
            s1.land = "Österreich";
            Spieler s2 = new Spieler("ID15326", new DateTime(1992, 2, 2));
            s1.land = "Ungarn";
            Spieler s3 = new Spieler("MastaBlasta", new DateTime(1993, 3, 3));
            s1.land = "Irland";
            Spieler s4 = new Spieler("NoobSlayer69", new DateTime(1994, 4, 4));
            s1.land = "Norwegen";
            Spieler s5 = new Spieler("Rigobert", new DateTime(1995, 5, 5));
            s1.land = "Italien";
            Spieler s6 = new Spieler("ICheatedLol", new DateTime(1996, 6, 6));
            s1.land = "Frankreich";
            Spieler s7 = new Spieler("ShoWTimE", new DateTime(1997, 7, 7));
            s1.land = "Deutschland";
            Spieler s8 = new Spieler("Serral", new DateTime(1998, 8, 8));
            s1.land = "Finnland";
            Spieler s9 = new Spieler("Kontinuumstransfunktionator", new DateTime(1999, 9, 9));
            s1.land = "Planet Erde";
            Spieler s10 = new Spieler("Dude", new DateTime(2000, 10, 10));
            s1.land = "Polen";

            //Highscore erstellen
            Highscore h1 = new Highscore(6358, s1);
            Highscore h2 = new Highscore(7921, s2);
            Highscore h3 = new Highscore(8621, s3);
            Highscore h4 = new Highscore(2384, s4);
            Highscore h5 = new Highscore(9863, s5);
            Highscore h6 = new Highscore(10001, s6);
            Highscore h7 = new Highscore(7853, s7);
            Highscore h8 = new Highscore(4635, s8);
            Highscore h9 = new Highscore(8620, s9);
            Highscore h10 = new Highscore(1000, s10);

            //Tabelle erstellen
            Tabelle t1 = new Tabelle(new Highscore[10] { h1, h2, h3, h4, h5, h6, h7, h8, h9, h10 });

            //Test von t1
            foreach (Highscore item in t1.HighscoreListe)
            {
                item.AusgabeHighscore();
            }
            Console.WriteLine("----------------");

            //Methoden-Test
            t1.Sortieren();
            t1.BestFive();
            Console.WriteLine("------------------");
            foreach (Highscore item in t1.HighscoreListe)
            {
                item.AusgabeHighscore();
            }
            Console.WriteLine("--------------");

            //Test NeueHighscore
            Highscore h11 = new Highscore(100002, s6);

            t1.NeuerHighscore(h11);

            t1.Sortieren();
            t1.BestFive();

            Console.ReadKey();
        }
    }
}
