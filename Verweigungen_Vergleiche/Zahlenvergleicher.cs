using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivNegativ
{
    class Zahlenvergleicher
    {
        static void Main(string[] args)
        {
            Console.Title = "Zahlenvergleicher";

            Console.Write("Wie lautet deine erste Zahl? ");
            string eingabe = Console.ReadLine();
            int zahl1 = int.Parse(eingabe);

            Console.Write("Wie lautet deine zweite Zahl? ");
            eingabe = Console.ReadLine();
            int zahl2 = int.Parse(eingabe);

            if (zahl1 > zahl2)
            {
                Console.WriteLine("Deine erste Zahl ist größer.");
            }
            else
            {
                if (zahl1 == zahl2)
                    Console.WriteLine("Deine Zahlen sind gleich groß.");
                else
                    Console.WriteLine("Deine zweite Zahl ist größer.");
            }

            Console.ReadKey();
        }
    }
}
