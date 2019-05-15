using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsereHighscore
{
    class Spieler
    {
        //Felder-Deklaration
        private string name;
        public string land;
        private DateTime gebDat;

        //Eigenschaft
        public string Name
        {
            get { return name; }
        }

        //Konstruktor
        public Spieler(string name, DateTime gebDat)
        {
            this.name = name;
            this.gebDat = gebDat;
        }

        //Methoden
        public void AusgabeSpieler()
        {
            Console.WriteLine($"Der Spieler {name} aus {land} und wurde am " +
                $"{gebDat.ToShortDateString()} geboren.");
        }
    }
}
