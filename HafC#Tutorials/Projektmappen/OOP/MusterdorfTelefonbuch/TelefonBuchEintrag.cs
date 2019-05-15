using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterdorfTelefonbuch
{
    class TelefonBuchEintrag
    {
        public Person pers;
        public Adresse adr;
        public int telnr;

        public TelefonBuchEintrag(Person pers, Adresse adr, int telnr)
        {
            this.pers = pers;
            this.adr = adr;
            this.telnr = telnr;
        }

        public void AusgabeTelEintrag()
        {
            Console.Write(pers.AusgabePerson());
            Console.WriteLine(adr.AusgabeAdresse());
            Console.WriteLine("Die Telefonnummer lautet: {0}", telnr);
        }
    }
}
