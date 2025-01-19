using System;

namespace Rechnen
{
    internal class Potenzen
    {
        static void Main(string[] args)
        {
            Console.Title = "potenzen";

            Console.WriteLine("Ich berechne Potenzen.");

            // Zahlen einlesen
            Console.Write("Wie lautet die Basis? ");
            string eingabe = Console.ReadLine();
            int basis = int.Parse(eingabe);

            Console.Write("Wie lautet der Exponent? ");
            eingabe = Console.ReadLine();
            int exponent = int.Parse(eingabe);

            // Startwert festlegen
            int potenz = 1;

            // Abfrage ist Zusatzaufgabe
            if (exponent >= 0)
            {
                // Potenz berechnen
                for (int i = 1; i <= exponent; ++i)
                    potenz *= basis;

                // Ergebnis ausgeben
                Console.WriteLine($"{basis} hoch {exponent} ist gleich {potenz}.");
            }
            else
                Console.WriteLine("Der Exponent darf für dieses Programm nicht negativ sein.");

            


            Console.ReadKey();
        }
    }
}
