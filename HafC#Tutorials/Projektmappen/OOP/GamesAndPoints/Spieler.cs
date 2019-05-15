using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesAndPoints
{
    class Spieler
    {
        private string name;
        public string land;
        private DateTime GebDat;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Spieler(string name, DateTime gebDat)
        {
            this.name = name;
            GebDat = gebDat;
        }

        public void AusgabeSpieler()
        {
            Console.WriteLine($"Der Spieler {name} aus {land} ist am {GebDat.ToShortDateString()} geboren.");
        }
    }
}
