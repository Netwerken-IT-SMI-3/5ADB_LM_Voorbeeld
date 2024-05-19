using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebruikersnaam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bepaal de gebruikersnaam");
            Console.WriteLine("------------------------\n");

            Console.Write("Voer de familienaam in:\t");
            string FamNaam = Console.ReadLine();

            Console.Write("Voer de voornaam in:\t");
            string VoorNaam = Console.ReadLine();

            Console.Write("Voer de geboortedatum in:\t");
            DateTime GeboorteDatum = DateTime.Parse(Console.ReadLine());

            blBedrijsUser NewUser = new blBedrijsUser();

            Console.WriteLine(NewUser.MaakGebruikersnaam(FamNaam,VoorNaam,GeboorteDatum));
           
            Console.ReadKey();
        }
    }
}
