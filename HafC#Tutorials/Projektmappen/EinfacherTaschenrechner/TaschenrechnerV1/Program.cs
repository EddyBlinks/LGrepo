using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerV1
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1, zahl2, ergebnis;
            string auswahl;
            bool ueberpruefen;

            while (true)
            {
                do
                {
                    Console.Clear();
                    Console.Write("Bitte erste Zahl eingeben: ");
                    ueberpruefen = double.TryParse(Console.ReadLine(), out zahl1);
                    if (ueberpruefen == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Fehleingabe! Bitte überprüfen Sie Ihre Eingabe. Weiter mit beliebiger Taste...");
                        Console.ReadKey();
                    }
                } while (ueberpruefen == false);

                do
                {
                    Console.Clear();
                    Console.WriteLine($"Ihre erste Zahl ist {zahl1}.");
                    Console.Write("Bitte zweite Zahl eingeben: ");
                    ueberpruefen = double.TryParse(Console.ReadLine(), out zahl2);
                    if (ueberpruefen == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Fehleingabe! Bitte überprüfen Sie Ihre Eingabe. Weiter mit beliebiger Taste...");
                        Console.ReadKey();
                    }
                } while (ueberpruefen == false);

                do
                {
                    ueberpruefen = true;
                    Console.Clear();
                    Console.WriteLine("1. Zahl: " + zahl1);
                    Console.WriteLine($"2. Zahl: {zahl2}");
                    Console.WriteLine();
                    Console.WriteLine("(A)ddieren\t\t+");
                    Console.WriteLine("(S)ubtrahieren\t\t-");
                    Console.WriteLine("(M)ultiplizieren\t*");
                    Console.WriteLine("(D)ividieren\t\t/");
                    Console.WriteLine("E(x)it");
                    Console.WriteLine();
                    Console.Write("Bitte Rechenart wählen: ");
                    auswahl = Console.ReadLine();

                    switch (auswahl.ToUpper())
                    {
                        case "A":
                        case "+":
                            ergebnis = zahl1 + zahl2;
                            Console.WriteLine("Ihr Ergebnis ist: " + ergebnis);
                            break;
                        case "S":
                        case "-":
                            ergebnis = zahl1 - zahl2;
                            Console.WriteLine("Ihr Ergebnis ist: {0}", ergebnis);
                            break;
                        case "M":
                        case "*":
                            ergebnis = zahl1 * zahl2;
                            Console.WriteLine($"Ihr Ergebis ist: {ergebnis}");
                            break;
                        case "D":
                        case "/":
                            if (zahl2 == 0)
                            {
                                Console.WriteLine("Division durch 0 nicht möglich");
                            }
                            else
                            {
                                ergebnis = zahl1 / zahl2;
                                Console.WriteLine("Ihr Ergebnis ist: " + ergebnis);
                            }
                            break;
                        case "X":
                            Environment.Exit(0);
                            break;
                        default:
                            ueberpruefen = false;
                            Console.WriteLine("Fehleingabe. Bitte überprüfen Sie Ihre Eingabe." +
                                " Weiter mit beliebiger Taste...");
                            Console.ReadKey();
                            break;
                    }
                } while (ueberpruefen == false);

                Console.WriteLine("Weiter mit belibiger Taste...");
                Console.ReadKey();
            }
        }
    }
}
