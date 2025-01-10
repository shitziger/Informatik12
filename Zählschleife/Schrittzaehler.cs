using System;

namespace Rechnen
{
    internal class Schrittzaehler
    {
        static void Main(string[] args)
        {
            Console.Title = "Schrittzählen";

            Console.WriteLine("Ich zähle für dich.");

            // Zahlen einlesen
            Console.Write("Wo soll es losgehen? ");
            string eingabe = Console.ReadLine();
            int start = int.Parse(eingabe);

            Console.Write("Wo soll es hingehen? ");
            eingabe = Console.ReadLine();
            int ende = int.Parse(eingabe);

            Console.Write("Welche Schrittweite soll ich wählen? ");
            eingabe = Console.ReadLine();
            int schritt = int.Parse(eingabe);

            // Abfrage ist Zusatzaufgabe
            if (start < ende)
            {
                // Schritte berechnen und ausgeben
                for (int i = start; i <= ende; i += schritt)
                    Console.WriteLine($"\t {i}"); // \t rückt ein

                
            }
            else // Zusatzaufgabe -> Rückwärts
            {
                // Schritte berechnen und ausgeben
                for (int i = start; i >= ende; i -= schritt)
                    Console.WriteLine($"\t {i}");
            }

            Console.ReadKey();
        }
    }
}
