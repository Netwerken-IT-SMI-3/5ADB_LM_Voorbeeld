using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace auto
{
    internal class blVerbruik
    {
        public double berekening(double IAfstand, double IVerbruik, double IPrijs)
        {
           return (IAfstand * IVerbruik / 100) * IPrijs;
        }

    }
}
