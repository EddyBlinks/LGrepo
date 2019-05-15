using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterdorfTelefonbuch
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1912, 12, 24);

            Person p1 = new Person("Hans", "Wurst", d1);
            Person p2 = new Person("Helga", "Wurst", new DateTime(1920, 12, 31));

            Adresse a1 = new Adresse("Metzgereigasse", 1);
            Adresse a2 = new Adresse("Fleischereistrasse", 3);

            TelefonBuchEintrag tel1 = new TelefonBuchEintrag(p1, a1, 123456);
            TelefonBuchEintrag tel2 = new TelefonBuchEintrag(p2, a2, 654321);
            TelefonBuchEintrag tel3 = new TelefonBuchEintrag
                (new Person("Roh", "Schinken", new DateTime(1954, 5, 1)),
                new Adresse("Hans-Jakob-Weg", 111),
                987456);

            //!!!Referenz-Typ!!!
            //Console.WriteLine(tel1.pers.nachname);
            //p1.nachname = "Worschtebrood";
            //Console.WriteLine(tel1.pers.nachname);

            TelefonBuchEintrag[] t1 = new TelefonBuchEintrag[3] { tel1, tel2, tel3 };

            //2 mal das gleiche Telefonbuch
            TelefonBuch telbuch1 = new TelefonBuch(t1);
            TelefonBuch telbuch2 = new TelefonBuch(new TelefonBuchEintrag[3]
            { tel1, tel2, tel3 });

            //Ausgabe und Referenztyp Teil 2
            telbuch1.AllesAnzeigen();
            t1[0] = tel2;
            Console.WriteLine();
            telbuch1.AllesAnzeigen();
            Console.WriteLine();
            telbuch1.telein[0] = tel1;

            foreach (TelefonBuchEintrag item in t1)
            {
                item.AusgabeTelEintrag();
            }

            Console.ReadKey();
        }

    }
}
