using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Linie
    {
        public Punkt p1;
        public Punkt p2;

        public Linie(Punkt p1, Punkt p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double LaengeLinie()
        {
            double deltaX = p1.x - p2.x;
            double deltaY = p1.y - p2.y;

            return Math.Round(Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2)), 2);
        }
    }
}
