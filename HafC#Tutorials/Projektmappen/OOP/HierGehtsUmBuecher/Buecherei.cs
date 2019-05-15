using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierGehtsUmBuecher
{
    class Buecherei
    {
        public string name, stadt;
        public Buch b1, b2, b3;

        public Buecherei(string name, string stadt, Buch b1, Buch b2, Buch b3)
        {
            this.name = name;
            this.stadt = stadt;
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }
    }
}
