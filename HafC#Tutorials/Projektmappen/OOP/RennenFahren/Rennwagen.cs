using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RennenFahren
{
    class Rennwagen
    {
        public int ps;
        public double maxGeschw;
        public double aktGeschw;
        public int pos;

        public Rennwagen(int ps, double maxGeschw, double aktGeschw, int pos)
        {
            if (ps < 1)
                this.ps = 1;
            else
                this.ps = ps;

            if (maxGeschw < 1)
                this.maxGeschw = 1;
            else
                this.maxGeschw = maxGeschw;

            if (aktGeschw < 0)
                this.aktGeschw = 0;
            else
                this.aktGeschw = aktGeschw;

            if (pos < 1)
                this.pos = 1;
            else
                this.pos = pos;
        }

        public void Beschleunigen(double erhoehen)
        {
            if (erhoehen < 0)
                erhoehen = 0;

            if (aktGeschw + erhoehen > maxGeschw)
                aktGeschw = maxGeschw;
            else
                aktGeschw = aktGeschw + erhoehen;
        }

        public void Bremsen(double verringern)
        {
            if (aktGeschw - verringern < 0)
                aktGeschw = 0;
            else
                aktGeschw = aktGeschw - verringern;
        }

        public void Stop()
        {
            aktGeschw = 0;
        }

        public void PositionAendern(int p)
        {
            if (p < 1)
                pos = 1;
            else
                pos = p;
        }
    }
}
