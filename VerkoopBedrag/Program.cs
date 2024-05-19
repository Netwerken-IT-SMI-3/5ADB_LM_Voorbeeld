using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkoopBedrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening van een bedrag inclusief BTW");
            Console.WriteLine("---------------------------------------\n");

            Console.Write("Voer het bedrag exclusief BTW in:\t");
            double bedragExcl = double.Parse(Console.ReadLine());

            Console.Write("Voer het BTW-percentage in:\t");
            double BTWPercentage = double.Parse(Console.ReadLine());

            //verwerking aan de hand van de businesslaag
            blBtwBerekenen nieuwBedrag = new blBtwBerekenen();
            double bedragIncl = nieuwBedrag.bedragInclBtwBerekenen(bedragExcl, BTWPercentage);

            Console.WriteLine($"Het bedrag inclusief BTW: {bedragIncl} EURO.");
            Console.ReadKey();
        }
    }
}
