using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourOperator
{
    internal class blReisPrijs
    {
        public double berekening(int IAantalReizigers)
        {
            double prijs = 0;

            if (IAantalReizigers < 21)
            {
                prijs = IAantalReizigers * 470;
            }
            else if (IAantalReizigers < 31)
            {
                prijs = 20 * 470;
                prijs += (IAantalReizigers - 20) * 450;
            }
            else
            {
                prijs = 20 * 470;
                prijs += 10 * 450;
                prijs += (IAantalReizigers - 30) * 430;
            }
            return prijs;
        }

        public double gemiddelde(int IAantalReizigers, double IKostPrijs)
        {
            return IKostPrijs / IAantalReizigers;
        }

    }
}
