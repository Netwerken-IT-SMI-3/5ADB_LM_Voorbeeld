using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Promille
{
    internal class blAlcohol
    {
        double ResultaatPromille = 0;

        public double BerekenGram(double IGewicht, double IGram)
        {
            double HoeveelheidBloed = 0;

            HoeveelheidBloed = IGewicht * 6.7 / 100;
            ResultaatPromille = (IGram / HoeveelheidBloed);

            return ResultaatPromille;
        }

        public double HoeveelDrinken()
        {
            double AantalEenheden = 0.5 / ResultaatPromille * 250;
            return AantalEenheden;
        }
        public double ComaDrinken()
        {
            double AantalEenheden = 4 / ResultaatPromille * 250;
            return AantalEenheden;
        }

    }
}
