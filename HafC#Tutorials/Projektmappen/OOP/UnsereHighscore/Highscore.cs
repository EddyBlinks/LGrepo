using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsereHighscore
{
    class Highscore
    {
        //Felder
        private int punktzahl;
        private Spieler spieler;

        //Eigenschaft
        public int Punktzahl
        {
            get { return punktzahl; }
        }


        //Konstruktor
        public Highscore(int punktzahl, Spieler spieler)
        {
            this.punktzahl = punktzahl;
            this.spieler = spieler;
        }

        //Methoden
        public void AusgabeHighscore()
        {
            Console.WriteLine($"Der Spieler {spieler.Name} hat {punktzahl}" +
                $" Punkte erreicht.");
        }
    }
}
