using System;
namespace OOPintermediate
{
    public class Autor
    {

        string vName, nName;
        DateTime dob, dod;
       

        public Autor(string vName, string nName, DateTime dob, DateTime dod)
        {
            this.vName = vName;
            this.nName = nName;
            this.dob = dob;
            this.dod = dod;


        }

        public void AutoInformaationen()
        {
            Console.WriteLine("Vorname: " + vName);
            Console.WriteLine("Nachname: " + nName);
            Console.WriteLine("Geburts Datum: " + dob.ToShortDateString());
            Console.WriteLine("Gestorben am: " + dod.ToShortDateString());


        }
    }
}
