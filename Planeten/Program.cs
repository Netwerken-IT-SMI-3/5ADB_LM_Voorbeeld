using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gewicht op een planeet");
            Console.WriteLine("----------------------\n");

            Console.WriteLine("Beschikbare planeten:\nmaan, Jupiter, Mars, Venus, Neptunus\n");

            Console.Write("Voer de planeet in waar je naar toe wilt gaan:\t");
            string Planeet = Console.ReadLine();

            Console.Write("Voer jouw gewicht in op aarde:\t");
            double Gewicht = double.Parse(Console.ReadLine());

            gewicht NieuwGewicht = new gewicht();

            Console.WriteLine($"Gewicht op de {Planeet}:\t{NieuwGewicht.gewichtBepalen(Planeet,Gewicht)}.");

            Console.ReadKey();

        }
    }
}
