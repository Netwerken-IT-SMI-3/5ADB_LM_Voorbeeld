using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EURO < - - > USD");
            Console.WriteLine("----------------\n");

            Console.Write("1)\tZet om van EURO naar USD\n");
            Console.Write("2)\tZet om van USD naar EURO\n");
            int keuze = int.Parse(Console.ReadLine());

            string munt = "";
            double Omgezet = 0;

            blOmzetting nieuwBedrag = new blOmzetting();
            if (keuze == 1)
            {
                munt = "EURO";
                Console.Write($"Voer jouw bedrag in {munt} in:\t");
                double OrigineelBedrag = double.Parse(Console.ReadLine());
                Omgezet = nieuwBedrag.EuroNaarUsd(OrigineelBedrag);
            }
            else if (keuze == 2)
            {
                munt = "USD";
                Console.Write($"Voer jouw bedrag in {munt} in:\t");
                double OrigineelBedrag = double.Parse(Console.ReadLine());
                Omgezet = nieuwBedrag.UsdNaarEuro(OrigineelBedrag);
            }

            Console.WriteLine($"Jouw nieuw bedrag:\t{Omgezet}.");
            Console.ReadKey();
        }
    }
}
