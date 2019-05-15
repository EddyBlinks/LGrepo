using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datum
{
    class Program
    {
        public string nachname;
        public string vorname;
        public DateTime gebdat;
        public DateTime sterbdat;
        public DateTime mydate = new DateTime(1985,05,03);
        static Program a1 = new Program();
        static void Main(string[] args)
        {
            Console.WriteLine(" date " + a1.mydate);
            Console.ReadKey();

        }
    }
}
