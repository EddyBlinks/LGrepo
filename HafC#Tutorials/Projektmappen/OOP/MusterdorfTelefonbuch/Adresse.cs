using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterdorfTelefonbuch
{
    class Adresse
    {
        public string strasse;
        public int hausnr;

        public Adresse(string strasse, int hausnr)
        {
            this.strasse = strasse;
            this.hausnr = hausnr;
        }

        public string AusgabeAdresse()
        {
            return $"wohnhaft in der {strasse} mit der Hausnummer {hausnr}";
        }
    }
}
