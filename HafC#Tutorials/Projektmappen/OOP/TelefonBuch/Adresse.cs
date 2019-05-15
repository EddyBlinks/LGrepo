using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBuch
{
    class Adresse
    {
        public string strasse;
        public int hausnummer;

        public Adresse(string strasse, int hausnummer)
        {
            this.strasse = strasse;
            this.hausnummer = hausnummer;
        }
    }
}
