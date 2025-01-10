using System;
using System.IO;

namespace Alter
{
    class Altersrechner
    {
        static void Main()
        {
            Console.Title = "Altersrechner";
            Console.Write("In welchem Jahr wurdest du geboren? ");
            string eingabe = Console.ReadLine();

            int geburtsjahr = int.Parse(eingabe);
            int alter = 2024 - geburtsjahr;
            // Wenn es immer gehen soll:
            // int alter = DateTime.Now.Year - geburtsjahr;

            Console.Write($"Wenn du im Jahr {geburtsjahr} geboren wurdest, bist du " +
                $"wahrscheinlich {alter} Jahre alt.");

            Console.ReadKey();
        }

    }
}
