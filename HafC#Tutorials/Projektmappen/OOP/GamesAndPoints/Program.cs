using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesAndPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Spieler s1 = new Spieler("Anton", new DateTime(1991, 1,1));
            s1.land = "Deutschland";
            Spieler s2 = new Spieler("Bernd", new DateTime(1992, 2, 2));
            s1.land = "Österreich";
            Spieler s3 = new Spieler("Charles", new DateTime(1993, 3, 3));
            s1.land = "Frankreich";
            Spieler s4 = new Spieler("Dora", new DateTime(1994, 4, 4));
            s1.land = "Schweiz";
            Spieler s5 = new Spieler("Franzi", new DateTime(1995, 5, 5));
            s1.land = "Brasilien";
            Spieler s6 = new Spieler("Gustav", new DateTime(1996, 6, 6));
            s1.land = "Malta";
            Spieler s7 = new Spieler("Horst", new DateTime(1997, 7, 7));
            s1.land = "Ungarn";
            Spieler s8 = new Spieler("Ingrid", new DateTime(1998, 8, 8));
            s1.land = "Polen";
            Spieler s9 = new Spieler("Jochen", new DateTime(1999, 9, 9));
            s1.land = "Irland";
            Spieler s10 = new Spieler("Klaus", new DateTime(2000, 10, 10));
            s1.land = "Niederlande";

            Highscore h1 = new Highscore(25, s1);
            Highscore h2 = new Highscore(125, s2);
            Highscore h3 = new Highscore(3425, s3);
            Highscore h4 = new Highscore(285, s4);
            Highscore h5 = new Highscore(23, s5);
            Highscore h6 = new Highscore(9863, s6);
            Highscore h7 = new Highscore(456, s7);
            Highscore h8 = new Highscore(876, s8);
            Highscore h9 = new Highscore(7451, s9);
            Highscore h10 = new Highscore(1, s10);

            Tabelle t1 = new Tabelle(new Highscore[10] { h1, h2, h3, h4, h5, h6, h7, h8, h9, h10 });

            t1.Sortieren();
            t1.BestFive();


            Console.ReadKey();
        }
    }
}
