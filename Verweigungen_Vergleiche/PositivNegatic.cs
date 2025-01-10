using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivNegativ
{
    class Vorzeichentester
    {
        static void Main(string[] args)
        {
            Console.Title = "Vorzeichentester";

            Console.Write("Wie lautet deine Zahl? ");
            string eingabe = Console.ReadLine();

            int zahl = int.Parse(eingabe);

            if (zahl > 0)
            {
                Console.WriteLine("Deine Zahl ist positiv.");
            }
            else
            {
                if (zahl == 0)
                    Console.WriteLine("Deine Zahl hat kein Vorzeichen.");
                else
                    Console.WriteLine("Deine Zahl ist negativ.");
            }

            Console.ReadKey();
        }
    }
}
