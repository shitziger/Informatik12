using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivNegativ
{
    class QuadratischeGleichungen
    {
        static void Main(string[] args)
        {
            Console.Title = "Quadratische Gleichungen";

            Console.WriteLine("Dieses Programm berechnet die Lösungen einer " +
                "Quadratischen Gleichung in der Form 0 = x² + px + q.");

            // p und q einlesen
            Console.Write("Wie lautet der Parameter p? ");
            string eingabe = Console.ReadLine();
            int p = int.Parse(eingabe);

            Console.Write("Wie lautet der Parameter q? ");
            eingabe = Console.ReadLine();
            int q = int.Parse(eingabe);

            // Diskriminante berechnen
            double D = p * p / 4.0 - q; // 4.0, weil es sonst die ganzzahlige Division stattfände

            // Keine Lösung ausschließen
            if (D < 0)
            {
                Console.WriteLine($"Die Gleichung 0 = x² + {p}x + {q} hat keine Lösungen.");
            }
            else
            {
                // Nur eine Lösung
                if (D == 0)
                {
                    double x = -p / 2.0; // + Wurzel D = 0
                    Console.WriteLine($"Die Gleichung 0 = x² + {p}x + {q} hat eine Lösung, nämlich x = {x}.");
                }
                else // Zwei Lösungen
                {
                    double x1 = -p / 2.0 + Math.Sqrt(D);
                    double x2 = -p / 2.0 - Math.Sqrt(D);

                    Console.WriteLine($"Die Gleichung 0 = x² + {p}x + {q} hat zwei Lösungen, " +
                        $"nämlich x1 = {x1} und x2 = {x2}.");
                }
            }

            Console.ReadKey();
        }
    }
}
