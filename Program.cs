using System;

namespace OOPintermediate
{
    class Program
    {
        static void Main(string[] args)
        {

            Autor auto1 = new Autor("Billy", "Goat", new DateTime(1946,2,4), new DateTime(1990,9,4));
            auto1.AutoInformaationen();


            Console.ReadKey();
        }
    }
}
