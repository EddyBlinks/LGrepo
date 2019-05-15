using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Rechteck
    {
        public Punkt p1;
        public Punkt p2;
        public Punkt p3;
        public Punkt p4;

        public Linie a;
        public Linie b;

        public Rechteck(Punkt p1, Punkt p3)
        {
            this.p1 = p1;
            this.p3 = p3;
            p2 = new Punkt(p3.x, p1.y);
            p4 = new Punkt(p1.x, p3.y);
            a = new Linie(p1, p2);
            b = new Linie(p2, p3);
        }

        public void AusgabeRechteck()
        {
            Console.WriteLine("P1: " + p1.KoordinatenAusgabe());
            Console.WriteLine("P2: " + p2.KoordinatenAusgabe());
            Console.WriteLine("P3: " + p3.KoordinatenAusgabe());
            Console.WriteLine("P4: " + p4.KoordinatenAusgabe());
            Console.WriteLine("Länge Linie a: " + a.LaengeLinie());
            Console.WriteLine("Länge Linie b: " + b.LaengeLinie());
        }
    }
}
