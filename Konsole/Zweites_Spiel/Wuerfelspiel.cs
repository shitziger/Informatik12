using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mein erster Multiplayer :-)";

            // Begrüßung
            Console.WriteLine("Lass uns gemeinsam ein Spiel spielen.\n");

            // Namen erfragen
            Console.Write("Spieler 1: Wie heißt du? ");
            string name1 = Console.ReadLine();
            Console.Write($"Hallo {name1}. Schön mit dir zu spielen.\n");

            Console.Write("Spieler 2: Wie heißt du? ");
            string name2 = Console.ReadLine();
            Console.Write($"Hallo {name2}. Schön auch mit dir zu spielen.\n");

            // Variablen Deklarieren
            int punkte1 = 0; // Punkte spieler 1
            int punkte2 = 0; // Punkte spieler 2
            int runde = 0;   // Punkte in der aktuellen Runde
            int wurf = 0;    // aktueller Wurf

            bool spieler = true; // spieler 1 = true, spieler 2 = false

            Random zufallsgenerator = new Random();

            // Das eigentliche Spiel:
            do
            {
                if (spieler)
                    Console.Write($"{name1} ist am Zug. Möchtest du würfeln? (j/n) ");
                else
                    Console.Write($"{name2} ist am Zug. Möchtest du würfeln? (j/n) ");

                string eingabe = Console.ReadLine();

                if (eingabe.Contains("j"))
                {
                    // Würfeln
                    wurf = zufallsgenerator.Next(1, 7);

                    Console.WriteLine($"Du hast eine {wurf} gewürfelt.");

                    if (wurf != 6) // Keine 6 gewürfelt
                    {
                        // runde erhöhen
                        runde += wurf;

                        if (spieler)
                        {
                            Console.WriteLine($"Du hast in dieser Runde jetzt {runde} Punkte erspielt. " +
                                $"Insgesamt hättest du jetzt theoretisch {runde + punkte1} Punkte.\n");
                        }
                        else
                        {
                            {
                                Console.WriteLine($"Du hast in dieser Runde jetzt {runde} Punkte erspielt. " +
                                    $"Insgesamt hättest du jetzt theoretisch {runde + punkte2} Punkte.\n");
                            }
                        }
                    }
                    else // 6 gewürfelt
                    {
                        Console.WriteLine("Oh nein... Du hast eine sechs gewürfelt. Alle deine Punkte sind nun verloren.\n");

                        // runde zurücksetzen
                        runde = 0;
                        // spieler ändern
                        spieler = !spieler;

                        Console.WriteLine("Zwischenstand:");
                        Console.WriteLine($"\t{name1} hat {punkte1} Punkte.");
                        Console.WriteLine($"\t{name2} hat {punkte2} Punkte.\n");
                    }

                }
                else // aufhören
                {
                    if (spieler)
                    {
                        // punkte addieren
                        punkte1 += runde;
                        // Verabschieden
                        Console.WriteLine($"Ok, ich habe dir die {runde} Punkte gutgeschrieben." +
                            $"Du hast jetzt {punkte1} Punkte.\nNun ist {name2} wieder dran.");
                    }
                    else
                    {
                        // punkte addieren
                        punkte2 += runde;
                        // Verabschieden
                        Console.WriteLine($"Ok, ich habe dir die {runde} Punkte gutgeschrieben." +
                            $"Du hast jetzt {punkte2} Punkte.\nNun ist {name1} wieder dran.");
                    }

                    // Werte zurücksetzen und ändern
                    runde = 0;
                    spieler = !spieler;

                    // Zwischenstand
                    Console.WriteLine("\nZwischenstand:");
                    Console.WriteLine($"\t{name1} hat {punkte1} Punkte.");
                    Console.WriteLine($"\t{name2} hat {punkte2} Punkte.\n");
                }

            } while (punkte1 < 60 && punkte2 < 60); // Das heißt, um tatsächlich zu gewinnen muss man
                                                    // seinen Druchgang noch beenden


            if (punkte1 > punkte2)
                Console.WriteLine($"\n\nGratulation: {name1}, du hast gewonnen!");
            else
                Console.WriteLine($"\n\nGratulation: {name1}, du hast gewonnen!");


            Console.ReadKey();
        }
    }
}
