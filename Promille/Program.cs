using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening promille");
            Console.WriteLine("-------------------\n");

            Console.Write("Voer jouw gewicht in:\t");
            double Gewicht = double.Parse(Console.ReadLine());

            Console.Write("Voer de hoeveelheid alcohol in (in gr.):\t");
            double GrAlcohol = double.Parse(Console.ReadLine());

            blAlcohol NieuwPromille = new blAlcohol();

            Console.WriteLine(NieuwPromille.BerekenGram(Gewicht, GrAlcohol));
            Console.WriteLine($"Je mag {NieuwPromille.HoeveelDrinken()} eenheden drinken.");
            Console.WriteLine($"Je valt in coma vanaf {NieuwPromille.ComaDrinken()} eenheden.");

            Console.ReadKey();
        }
    }
}
