using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwembad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening van de inhoud van een zwembad");
            Console.WriteLine("----------------------------------------\n");

            Console.Write("Voer de lengte van jouw zwembad in:\t");
            double lengte = double.Parse(Console.ReadLine());

            Console.Write("Voer de breedte van jouw zwembad in:\t");
            double breedte = double.Parse(Console.ReadLine());

            Console.Write("Voer de diepte van jouw zwembad in:\t");
            double diepte = double.Parse(Console.ReadLine());

            //verwerking aan de hand van de businesslaag
            blInhoudBerekenen nieuwZwembad = new blInhoudBerekenen();
            double water = nieuwZwembad.Inhoud(lengte,breedte,diepte);

            Console.WriteLine($"Jouw zwembad heeft een watercapaciteit van {water} m3 water.");
            Console.ReadKey();
        }
    }
}
