using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro
{
    internal class blOmzetting
    {
        public double EuroNaarUsd(double IBedrag)
        {
            return IBedrag * 1.08;
        }
        public double UsdNaarEuro(double IBedrag)
        {
            return IBedrag * 0.92; ;
        }
    }
}
