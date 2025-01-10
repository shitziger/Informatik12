using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Notenrechner";

            // Anzahl einlesen
            Console.Write("Wie viele Noten hast du bekommen? ");
            string eingabe = Console.ReadLine();
            int anzahl = int.Parse(eingabe);

            // Array erstellen
            int[] noten = new int[anzahl];

            // Noten einlesen
            for (int i = 0; i < noten.Length; i++)
            {
                Console.Write($"Wie lautet die {i + 1}. Note? ");
                int note = int.Parse(Console.ReadLine());

                noten[i] = note;
            }

            // Durchschnitt berechnen
            double summe = 0;
            for (int i = 0; i < noten.Length; ++i)
                summe += noten[i];

            double durchschnitt = summe / anzahl;

            // Ausgabe
            Console.WriteLine($"Du hast einen Durchschnitt von {durchschnitt}.");


            Console.ReadKey();
        }
    }
}
