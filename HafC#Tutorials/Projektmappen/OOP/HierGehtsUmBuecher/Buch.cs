using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierGehtsUmBuecher
{
    class Buch
    {
        public string isbn;
        public string titel;
        public Autor autor;
        public bool verliehen;

        public Buch(string isbn, string titel, Autor autor, bool verliehen)
        {
            this.isbn = isbn;
            this.titel = titel;
            this.autor = autor;
            this.verliehen = verliehen;
        }

        public void Ausgabe()
        {
            Console.WriteLine($"Das Buch hat den Titel {titel} und wurde von {autor.vorname}" +
                $" {autor.nachname} geschrieben.");
            Console.WriteLine("Die ISBN lautet: " + isbn);
            if(verliehen == true)
                Console.WriteLine("Das Bucht ist verliehen.");
            else
                Console.WriteLine("Das Buch ist verfügbar.");
        }

        public void Verleihen()
        {
            verliehen = true;
        }

        public void ZurueckGeben()
        {
            verliehen = false;
        }
    }
}
