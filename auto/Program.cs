using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bereken het verbruik van de auto");
            Console.WriteLine("--------------------------------\n");

            blVerbruik NieuweAuto = new blVerbruik();
            
            Console.Write("Voer de afgelegde afstand in:\t");
            double afstand = double.Parse(Console.ReadLine());
            Console.Write("Voer het verbruik (in L/100km) in:\t");
            double verbruik = double.Parse(Console.ReadLine());
            Console.Write("Voer de prijs van de brandstof (in EURO/L) in:\t");
            double prijs = double.Parse(Console.ReadLine());

            double kostPrijs = NieuweAuto.berekening(afstand, verbruik, prijs);

            Console.WriteLine($"Jouw tripje kost {kostPrijs} EURO aan brandstof.");
            Console.ReadKey();

        }
    }
}
