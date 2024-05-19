using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Touroperator");
            Console.WriteLine("------------\n");

            blReisPrijs NieuweReis = new blReisPrijs();

            Console.Write("Hoeveel reizigers gaan er mee?\t");
            int aantalReizigers = int.Parse(Console.ReadLine());

            double kostPrijs = NieuweReis.berekening(aantalReizigers);
            double gemiddeldePrijs = NieuweReis.gemiddelde(aantalReizigers, kostPrijs);

            Console.WriteLine($"Jouw tripje kost {kostPrijs} EURO in totaal.");
            Console.WriteLine($"Jouw tripje kost {gemiddeldePrijs} EURO per persoon.");

            Console.ReadKey();
        }
    }
}
