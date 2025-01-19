using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Wochentag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Wochentagsrechner";

            while (true) // Endlosschleife für beliebig viele Abfragen
            {
                // Datum einlesen
                Console.WriteLine("Für welches Datum soll der Wochentag berechnet werden?");
                Console.WriteLine("\t(Eingabe 0 für Beenden)");
                Console.Write("Tag des Datums: ");
                int tag = int.Parse(Console.ReadLine());

                // Abbrechen bei Eingabe 0
                if (tag == 0)
                    break; // Beendet die Schleife

                // Rest einlesen
                Console.Write("Monat des Datums: ");
                int monat = int.Parse(Console.ReadLine());
                Console.Write("Jahr des Datums: ");
                int jahr = int.Parse(Console.ReadLine());

                // Eingelesenes Datum ausgeben
                //Console.WriteLine($"Eingelesen: {tag}.{monat}.{jahr}");

                // Kleine Jahreszahlen interpretieren
                if (jahr < 100)
                {
                    int echtJahr = jahr < 30 ? 2000 + jahr : 1900 + jahr;
                    Console.Write($"Meintest du tatsächlich das Jahr {jahr} (j) oder eher das Jahr {echtJahr} (n)? (j/n) ");
                    if (Console.ReadLine().ToUpper() == "N")
                        jahr = echtJahr;
                }

                // Datum prüfen
                if (!CheckDatum(tag, monat, jahr)) // Datum NICHT korrekt
                {
                    Console.WriteLine("Das angegebene Datum existiert nicht");
                    continue; // Springt zur nächsten Runde
                }

                string wochentag = BerechneWochentag(tag, monat, jahr);

                Console.WriteLine($"Der {tag}.{monat}.{jahr} war/ist ein {wochentag}.");
                
            }

            // Wird mit Schleife nicht benötigt:
            //Console.ReadKey();
        }
        static string BerechneWochentag(int tag, int monat, int jahr)
        {
            // Ziffern
            int tagesziffer = GetTageziffer(tag);
            int monatsziffer = GetMonatsziffer(monat);
            int jahrhundertziffer = GetJahrhundertziffer(jahr);
            int jahresziffer = GetJahresziffer(jahr);

            int wochentagsziffer = (tagesziffer + monatsziffer + jahrhundertziffer + jahresziffer) % 7;

            // Schaltjahr prüfen
            if (IstSchaltjahr(jahr))
            {
                if (monat == 1 || monat == 2)
                    wochentagsziffer = wochentagsziffer == 0 ? 6 : wochentagsziffer - 1;
            }

            return GetWochentag(wochentagsziffer);
        }
        static bool CheckDatum(int tag, int monat, int jahr)
        {
            // tag < 1 oder > 31
            if (tag < 1 || tag > 31)
                return false;

            // monat < 1 oder > 12
            if (monat < 1 || monat > 12)
                return false;

            switch (monat)
            {
                // Monate mit 30 Tagen
                case 4:
                case 6:
                case 9:
                case 11:
                    if (tag > 30)
                        return false;
                    break;
                // Februar
                case 2:
                    if (IstSchaltjahr(jahr) && tag > 29)
                        return false;
                    if (tag > 28)
                        return false;
                    break;
                // restliche Monate mit > 31 wurde bereits oben geprüft
            }

            return true;
        }
        static bool IstSchaltjahr(int jahr)
        {
            if (jahr % 4 == 0)
            {
                if (jahr % 100 == 0 && jahr % 400 != 0)
                    return false;
                else
                    return true;
            }
            else
            {
                return false;
            }
        }
        static int GetTageziffer(int tag)
        {
            return tag % 7;
        }
        static int GetMonatsziffer(int monat)
        {
            switch (monat)
            {
                // Mai
                case 5: return 0;
                // August
                case 8: return 1;
                // Februar, März, November
                case 2:
                case 3:
                case 11: return 2;
                // Juni
                case 6: return 3;
                // September, Dezember
                case 9:
                case 12: return 4;
                // April, Juli
                case 4:
                case 7: return 5;
                // Januar, Oktober
                case 1:
                case 10: return 6;
                // Sonstige Monate (Fehler)
                default: return -1;
            }
        }
        static int GetJahrhundertziffer(int jahr)
        {
            int jahrhundert = jahr / 100; // int-Division schneidet Rest einfach ab
            int rest = jahrhundert % 4;

            return 2 * (3 - rest) + 1;
        }
        static int GetJahresziffer(int jahr)
        {
            int jahreszahl = jahr % 100;
            jahreszahl += jahreszahl / 4;

            return jahreszahl % 7;
        }
        static string GetWochentag(int wochentagsziffer)
        {
            switch(wochentagsziffer)
            {
                case 0: return "Sonntag";
                case 1: return "Montag";
                case 2: return "Dienstag";
                case 3: return "Mittwoch";
                case 4: return "Donnerstag";
                case 5: return "Freitag";
                case 6: return "Samstag";

                default: return "Fehler in der Wochentagsziffer";
            }

        }
    }
}
