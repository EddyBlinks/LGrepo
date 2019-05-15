using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierGehtsUmBuecher
{
    class Autor
    {
        public string nachname;
        public string vorname;
        public DateTime gebDat;
        public DateTime sterbDat;

        public Autor(string vorname, string nachname, DateTime gebDat, DateTime sterbDat)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.gebDat = gebDat;
            this.sterbDat = sterbDat;
        }
    }
}
