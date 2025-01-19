using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wochentag
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ich berechne den Wochentag.");

            // Einlesen
            Console.Write("Wie lautet der Tag des Datums? ");
            string eingabe = Console.ReadLine();
            int tag = int.Parse(eingabe);

            Console.Write("Wie lautet der Monat des Datums? ");
            eingabe = Console.ReadLine();
            int monat = int.Parse(eingabe);

            Console.Write("Wie lautet das Jahr des Datums? ");
            eingabe = Console.ReadLine();
            int jahr = int.Parse(eingabe);

            // Ziffern berechnen

            int tagesziffer = tag % 7;

            int monatsziffer = 2; // Feb, Mar, Nov
            if (monat == 1 || monat == 10) // Jan, Okt
                monatsziffer = 6;
            if (monat == 4 || monat ==7) // Apr, Jul
                monatsziffer = 5;
            if (monat == 5) // Mai
                monatsziffer = 0;
            if (monat == 6) // Jun
                monatsziffer = 3;
            if (monat == 8) // Aug
                monatsziffer = 1;
            if (monat == 9 || monat == 12) // Sep, Dez
                monatsziffer = 4;

            int jahrhundert = jahr / 100; // Integerdivision rundet immer ab
            int jahrhundertziffer = jahrhundert % 4;
            jahrhundertziffer = 2 * (3 - jahrhundertziffer) + 1;

            int jahreszahl = jahr % 100;
            int jahresziffer = jahreszahl / 4;
            jahresziffer += jahreszahl;
            jahresziffer %= 7;

            int wochentagsziffer = tagesziffer + monatsziffer + jahrhundertziffer + jahresziffer;
            wochentagsziffer %= 7;

            // Schaltjahr prüfen
            if ((jahr % 4 == 0 && jahr % 100 != 0) || jahr % 400 == 0) // durch 4 aber nicht durch 100 teilbar ODER durch 400 teilbar
            {
                if (monat == 1 || monat == 2)
                {
                    wochentagsziffer -= 1;
                    if (wochentagsziffer == -1)
                        wochentagsziffer = 6;
                }
            }

            // Wochentag bestimmen
            string wochentag = "";
            if (wochentagsziffer == 0)
                wochentag = "Sonntag";
            if (wochentagsziffer == 1)
                wochentag = "Montag";
            if (wochentagsziffer == 2)
                wochentag = "Dienstag";
            if (wochentagsziffer == 3)
                wochentag = "Mittwoch";
            if (wochentagsziffer == 4)
                wochentag = "Donnerstag";
            if (wochentagsziffer == 5)
                wochentag = "Freitag";
            if (wochentagsziffer == 6)
                wochentag = "Samstag";

            // Ausgabe
            Console.WriteLine($"Der {tag}.{monat}.{jahr} war/ist ein {wochentag}.");

            Console.ReadKey();

        }
    }
}
