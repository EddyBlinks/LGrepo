using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EigenschaftenBank
{
    class Konto
    {
        public Person inhaber;
        private decimal kontostand;
        public int kontonr;

        public decimal Kontostand
        {
            get
            {
                return kontostand;
            }
            set
            {
                if (value <= kontostand + 0.50m)
                {
                    kontostand = value;
                }
            }
        }

        public Konto()
        {
            kontostand = 5.20m;
        }

        public void KontostandAnzeigen()
        {
            Console.WriteLine("Ihr aktueller Kontostand ist: "
                + Math.Round(kontostand, 2));
        }

        public void Abheben(decimal betrag)
        {
            if (betrag < 0)
            {
                Console.WriteLine("Betrag muss positiv sein");
            }
            else if (kontostand - betrag < 0)
            {
                Console.WriteLine("Abhebung nicht möglich, Kontostand zu niedrig.");
            }
            else
            {
                //kontostand = kontostand - betrag
                kontostand -= betrag;
            }
        }

        public void Einzahlen(decimal betrag)
        {
            if (betrag < 0)
            {
                Console.WriteLine("Betrag muss positiv sein");
            }
            else
            {
                //kontostand = kontostand + betrag
                kontostand += betrag;
            }
        }
    }
}
