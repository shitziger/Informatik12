using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivNegativ
{
    class Schaltjahr
    {
        static void Main(string[] args)
        {
            Console.Title = "Schaltjahrprüfer";

            Console.Write("Welches Jahr soll geprüft werden? ");
            string eingabe = Console.ReadLine();
            int jahr = int.Parse(eingabe);


            if (jahr % 4 == 0)
            {
                if (jahr % 100 == 0)
                {
                    if (jahr % 400 == 0)
                        Console.WriteLine($"Das Jahr {jahr} war ein Schaltjahr.");
                    else
                        Console.WriteLine($"Das Jahr {jahr} war kein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine($"Das Jahr {jahr} war ein Schaltjahr.");
                }
            }
            else
            {
                Console.WriteLine($"Das Jahr {jahr} war kein Schaltjahr.");
            }

            Console.ReadKey();
        }
    }
}
