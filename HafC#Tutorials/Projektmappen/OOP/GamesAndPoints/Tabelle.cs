using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesAndPoints
{
    class Tabelle
    {
        private Highscore[] highScoreListe;

        public Tabelle(Highscore[] highScoreListe)
        {
            this.highScoreListe = highScoreListe;
        }

        internal void Sortieren()
        {
            for (int i = 0; i < highScoreListe.Length - 1; i++)
            {
                for (int j = i + 1; j < highScoreListe.Length; j++)
                {
                    if (highScoreListe[i].Punktzahl < highScoreListe[j].Punktzahl)
                    {
                        Swap(highScoreListe, i, j);
                    }
                }
            }
        }

        internal void BestFive()
        {
            highScoreListe[0].AusgabeHighscore();
            highScoreListe[1].AusgabeHighscore();
            highScoreListe[2].AusgabeHighscore();
            highScoreListe[3].AusgabeHighscore();
            highScoreListe[4].AusgabeHighscore();
        }

        public void NeuerHighscore(Highscore h)
        {
            Sortieren();
            if (h.Punktzahl > highScoreListe[highScoreListe.Length - 1].Punktzahl)
            {
                highScoreListe[highScoreListe.Length - 1] = h;
            }
        }

        static void Swap(Highscore[] liste, int a, int b)
        {
            Highscore temp = liste[a];
            liste[a] = liste[b];
            liste[b] = temp;
        }
    }
}
