using System;


namespace Program
{
    class Notenrechner  
    {
        static void Main()
        {
            Console.Title = "Notenrechner";

            // Noten einlesen
            Console.Write("Wie lauten deine Noten? ");
            string eingabe = Console.ReadLine();

            string[] einzelnoten = eingabe.Split(',');
            int[] noten = new int[einzelnoten.Length];

            // Noten umwandeln
            for (int i = 0; i < noten.Length; i++)
                noten[i] = int.Parse(einzelnoten[i]);

            // Durchschnitt berechnen
            double summe = 0;

            for (int i = 0; i < noten.Length; i++)
                summe += noten[i];

            double durchschnitt = summe / noten.Length;

            // Ausgabe
            Console.WriteLine($"Du hast einen Durchschnitt von {durchschnitt}.");
            

            Console.ReadKey();
        }
    }
}