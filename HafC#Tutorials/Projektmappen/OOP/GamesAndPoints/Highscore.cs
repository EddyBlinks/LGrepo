using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesAndPoints
{
    class Highscore
    {
        private int punktzahl;
        private Spieler spieler;

        public int Punktzahl
        {
            get { return punktzahl; }
            set { punktzahl = value; }
        }


        public Highscore(int punktzahl, Spieler spieler)
        {
            this.punktzahl = punktzahl;
            this.spieler = spieler;
        }

        public void AusgabeHighscore()
        {
            Console.WriteLine($"Der Spieler {spieler.Name} hat {punktzahl}");
        }
    }
}
