using System;

namespace Spiel
{
    internal class ZahlenRaetsler
    {
        static void Main(string[] args)
        {
            Console.Title = "Zahlenraten";
            Console.WriteLine("Ich denke mir eine Zahl zwischen 1 und 100.");

            // Zufallszahl erzeugen
            Random zufallsGenerator = new Random();
            int zufallsZahl = zufallsGenerator.Next(1, 101);

            // Variablen deklarieren
            int zahl;
            int zaehler = 0;

            do
            {
                // Versuch einlesen
                Console.Write("Welche Zahl könnte ich gedacht haben? ");
                string eingabe = Console.ReadLine(); 
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
