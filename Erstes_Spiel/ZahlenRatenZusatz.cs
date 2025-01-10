using System;

namespace Spiel
{
    internal class ZahlenRaetsler
    {
        static void Main(string[] args)
        {
            Console.Title = "Zahlenraten";

            Console.WriteLine("Ich möchte ein Spiel mit dir spielen.");

            // Schwierigkeitsgrad einlesen
            Console.Write("Welchen Schwierigkeitsgrad hättest du gern? (1 bis 7) ");
            string eingabe = Console.ReadLine();
            int schwierig = int.Parse(eingabe);

            // Maximalzahl berechnen
            int max = (int)Math.Pow(10, schwierig); // Berechnet 10 hoch schwierig, und wandelt zurück in int um

            Console.WriteLine($"Ich denke mir eine Zahl zwischen 1 und {max}.");

            // Zufallszahl erzeugen
            Random zufallsGenerator = new Random();
            int zufallsZahl = zufallsGenerator.Next(1, max + 1);

            // Variablen deklarieren
            int zahl;
            int zaehler = 0;

            do
            {
                // Versuch einlesen
                Console.Write("Welche Zahl könnte ich gedacht haben? ");
                eingabe = Console.ReadLine(); 
                zahl = int.Parse(eingabe);

                // Hinweis geben
                if (zahl < zufallsZahl)
                    Console.WriteLine($"Die Zahl {zahl} ist zu klein.");
                if (zahl > zufallsZahl)
                    Console.WriteLine($"Die Zahl {zahl} ist zu groß.");

                zaehler++;

            }while (zahl != zufallsZahl); // Wiederholen, solange die Eingabe falsch ist.

            // Sieg verkünden
            Console.WriteLine($"Gratulation! Du hast die gesuchte Zahl ({zufallsZahl}) nach {zaehler} Versuchen richtig geraten.");

            Console.ReadKey();
        }
    }
}
