using System;

namespace Rechnen
{
    internal class Einmaleins
    {
        static void Main(string[] args)
        {
            Console.Title = "Das kleine Einmaleins";

            // Malfolge einlesen
            Console.Write("Welche Malfolge soll dargestellt werden? ");
            string eingabe = Console.ReadLine();
            int folge = int.Parse(eingabe);

            // Abfrage ist Zusatzaufgabe
            if (folge > 0 && folge < 11)
            {
                for (int i = 1; i <= 10; ++i) // Malfolge ausgeben
                    Console.WriteLine($"{folge} x {i} = {folge * i}");
            }
            else
                Console.WriteLine($"Die gewählte Malfolge der Zahl {folge} gehört nicht zum KLEINEN Einmaleins.");

            Console.ReadKey();
        }
    }
}
