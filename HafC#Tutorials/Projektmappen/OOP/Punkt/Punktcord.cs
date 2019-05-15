using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punkt
{
    class Punktcord
    {
        public int xco;
        public int yco;

        public void Coordinate()
        {
           
            Console.WriteLine("geben sie die x coordinate");
            xco = int.Parse(Console.ReadLine());
            Console.WriteLine("geben sie die y coordinate");
            yco = int.Parse(Console.ReadLine());
            Console.WriteLine($"P:({xco},{yco})");
        }

  
    }
}
