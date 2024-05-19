using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeten
{
    internal class gewicht
    {
        private double gewichtMaan(double IGewicht)
        {
            return IGewicht * 0.1666;
        }
        private double gewichtJupiter(double IGewicht)
        {
            return IGewicht * 2.36;
        }
        private double gewichtMars(double IGewicht)
        {
            return IGewicht * 0.37;
        }
        private double gewichtVenus(double IGewicht)
        {
            return IGewicht * 0.9;
        }
        private double gewichtNeptunus(double IGewicht)
        {
            return IGewicht * 1.12;
        }

        public double gewichtBepalen(string IPlaneet, double IGewicht) 
        {
            double resultaat = 0;

            switch (IPlaneet.ToLower())
            {
                case "maan":
                    resultaat = gewichtMaan(IGewicht);
                    break;
                case "mars":
                    resultaat = gewichtMars(IGewicht);
                    break;
                case "jupiter":
                    resultaat = gewichtJupiter(IGewicht);
                    break;
                case "venus":
                    resultaat = gewichtVenus(IGewicht);
                    break;
                case "neptunus":
                    resultaat = gewichtNeptunus(IGewicht);
                    break;
                default:
                    break;
            }

            return resultaat;
        }
    }
}
