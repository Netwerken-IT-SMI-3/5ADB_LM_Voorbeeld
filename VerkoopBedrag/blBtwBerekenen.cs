using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkoopBedrag
{
    internal class blBtwBerekenen
    {
        public double bedragInclBtwBerekenen(double IBedragExcl, double IBtwPercentage)
        {
            double BedragIncl;

            if (IBtwPercentage == 6 || IBtwPercentage == 21)
            {
                BedragIncl = IBedragExcl * (1 + (IBtwPercentage / 100));

            }
            else
            {
                BedragIncl = 999;
            }
            return BedragIncl;
        }
    }
}
