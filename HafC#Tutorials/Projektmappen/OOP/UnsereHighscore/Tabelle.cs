using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsereHighscore
{
    class Tabelle
    {
        //Felder
        private Highscore[] highscoreListe;

        //Eigenschaft
        public Highscore[] HighscoreListe
        {
            get { return highscoreListe; }
        }

        //Konstruktor
        public Tabelle(Highscore[] highscoreListe)
        {
            this.highscoreListe = highscoreListe;
        }

        //Methoden
        static public void Swap(Highscore[] h, int a, int b)
        {
            Highscore temp = h[a];
            h[a] = h[b];
            h[b] = temp;
        }

        internal void Sortieren()
        {
            for (int i = 0; i < highscoreListe.Length; i++)
            {
                for (int j = i + 1; j < highscoreListe.Length; j++)
                {
                    if (highscoreListe[i].Punktzahl < highscoreListe[j].Punktzahl)
                    {
                        Swap(highscoreListe, i, j);
                    }
                }
            }

        }

        internal void BestFive()
        {
            for (int i = 0; i < 5; i++)
            {
                highscoreListe[i].AusgabeHighscore();
            }
        }

        public void NeuerHighscore(Highscore high)
        {
            Sortieren();
            if (high.Punktzahl > HighscoreListe[highscoreListe.Length -1].Punktzahl)
            {
                HighscoreListe[highscoreListe.Length - 1] = high;
            }
        }
    }
}
