using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class Bildschirm
    {
        public string farbe;
        public double groesse;
        public int aufloesungHoehe, aufloesungBreite;
        public short hertz;

        public Bildschirm() { }

        public Bildschirm(double groesse, int aufloesungHoehe, int aufloesungBreite,
            short hertz)
        {
            farbe = "weiss";
            this.groesse = groesse;

            if (aufloesungHoehe < 0)
            {
                this.aufloesungHoehe = aufloesungHoehe * -1;
            }
            else
            {
                this.aufloesungHoehe = aufloesungHoehe;
            }

            this.aufloesungBreite = aufloesungBreite;
            this.hertz = hertz;
        }

        public Bildschirm(string farbe, double groesse, int aufloesungHoehe,
            int aufloesungBreite, short hertz)
        {
            this.farbe = farbe;
            this.groesse = groesse;
            this.aufloesungHoehe = aufloesungHoehe;
            this.aufloesungBreite = aufloesungBreite;
            this.hertz = hertz;
        }

    }
}
