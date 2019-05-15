using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBuch
{
    class Person
    {
        public string vorname;
        public string nachname;
        public DateTime gebDat;

        public Person(string vorname, string nachname, DateTime gebDat)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.gebDat = gebDat;
        }
    }
}
