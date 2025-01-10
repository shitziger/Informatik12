using System;
using System.Diagnostics.Eventing.Reader;

namespace Rechnen
{
    internal class Primzahl
    {
        static void Main(string[] args)
        {
            Console.Title = "Primzahlprüfer";

            // Zahlen einlesen
            Console.Write("Welche Zahl soll geprüft werden? ");
            string eingabe = Console.ReadLine();
            int zahl = int.Parse(eingabe);

            // Primzahl ist, wer nur durch 1 und sich selbst teilbar ist
            bool istPrimzahl = true;

            // Alle Zahlen bis zahl prüfen
            for (int i = 2; i < zahl; i++)
            {
                if (zahl % i == 0) // Wenn die Division einen Rest gibt, ist die Zahl teilbar
                    istPrimzahl = false;
            }

            if (istPrimzahl)
                Console.WriteLine($"{zahl} ist eine Primzahl.");
            else
                Console.WriteLine($"{zahl} ist keine Primzahl.");


            // Etwas performanter ist die folgende Variante:
            for (int i = 2; i < zahl && istPrimzahl; i++)
            {                           // Schleife wird beendet, sobald ein Teiler gefunden wurde

                if (zahl % i == 0) // Wenn die Division einen Rest gibt, ist die Zahl teilbar
                    istPrimzahl = false;
            }

            Console.ReadKey();
        }
    }
}
