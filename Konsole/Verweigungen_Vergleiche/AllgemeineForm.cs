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
                "Quadratischen Gleichung in der Form 0 = ax² + bx + c.");

            // a, b und c einlesen
            Console.Write("Wie lautet der Parameter a? ");
            string eingabe = Console.ReadLine();
            int a = int.Parse(eingabe);

            Console.Write("Wie lautet der Parameter b? ");
            eingabe = Console.ReadLine();
            int b = int.Parse(eingabe);

            Console.Write("Wie lautet der Parameter c? ");
            eingabe = Console.ReadLine();
            int c = int.Parse(eingabe);

            // Diskriminante berechnen
            double D = b * b - 4 * a * c;

            // Keine Lösung ausschließen
            if (D < 0)
            {
                Console.WriteLine($"Die Gleichung 0 = {a}x² + {b}x + {c} hat keine Lösungen.");
            }
            else
            {
                // Nur eine Lösung
                if (D == 0)
                {
                    double x = -b / (2.0 * a); // + Wurzel D = 0 // 2.0, damit es keine ganzzalige Division wird
                    Console.WriteLine($"Die Gleichung 0 = {a}x² + {b}x + {c} hat eine Lösung, nämlich x = {x}.");
                }
                else // Zwei Lösungen
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                    Console.WriteLine($"Die Gleichung 0 = {a}x² + {b}x + {c} hat zwei Lösungen, " +
                        $"nämlich x1 = {x1} und x2 = {x2}.");
                }
            }

            Console.ReadKey();
        }
    }
}
