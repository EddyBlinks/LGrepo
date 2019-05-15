using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArr = new int[5];
            ArrayList arrList = new ArrayList();

            //Hinzufügen am Ende der ArrayList
            arrList.Add("Hallo ");
            arrList.Add("Welt! ");
            arrList.Add("Dynamische Listen ");
            arrList.Add("sind ganz toll.");

            //Größe der ArrayList
            Console.WriteLine(arrList.Count);

            //Ausgabe
            foreach (string item in arrList)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            arrList.Add(15.2);

            foreach (var item in arrList)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("---------------------");

            //Einfügen an Index-Stelle
            arrList.Insert(0, 42);

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------");

            //Löschen
            arrList.Remove(42);

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            arrList.RemoveAt(4);

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");
            //Leerung des Arrays
            arrList.Clear();

            arrList.Add("Hallo");
            arrList.Add("welt");
            arrList.Add("ich");
            arrList.Add("frage");
            arrList.Add("Hallo");

            //Löschung aller "Hallo"
            while (arrList.IndexOf("Hallo") >= 0)
                arrList.Remove("Hallo");


            Console.WriteLine(arrList.IndexOf("du"));

            //Ausgabe
            Console.WriteLine(arrList[1]);

            Console.ReadKey();
        }
    }
}
