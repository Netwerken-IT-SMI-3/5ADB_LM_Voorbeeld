using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ADB_LM_Voorbeeld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening van de gemiddelde snelheid");
            Console.WriteLine("-------------------------------------\n");

            //invoer van de gegevens
            Console.Write("Voer de afstand in (in km):\t");
            double Afstand = double.Parse(Console.ReadLine());

            Console.Write("Voer de tijd in (in uren):\t");
            double Tijd = double.Parse(Console.ReadLine());

            //verwerking: berekening van de gemiddelde snelheid
            //een object/instantie maken van de businesslayer
            SnelheidsBerekenaar MijnSnelheid = new SnelheidsBerekenaar();
            double gemiddeldeSnelheid = MijnSnelheid.BerekenGemiddeldeSnelheid(Afstand, Tijd);

            //uitvoer van de gemiddelde snelheid
            Console.WriteLine($"De gemiddelde snelheid is: {gemiddeldeSnelheid} km/u.");
            Console.ReadKey();
        }
    }
}
