using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Punkt
    {
        public double x;
        public double y;

        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public string KoordinatenAusgabe()
        {
            return $"Koordinaten des Punktes: P({x}|{y})";
        }

        //public void Ausgabe2()
        //{
        //    Console.WriteLine($"Koordinaten des Punktes: P({x}|{y})");
        //}
    }
}
