using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebruikersnaam
{
    internal class blBedrijsUser
    {
        private string MaakFamNaamCode(string INaam)
        {
            return INaam.Substring(0,3).ToUpper();        
        }
        private string MaakVoorNaamCode(string IVoorNaam)
        {
            return IVoorNaam.Substring(0, 3).ToLower();
        }
        private string MaakJaartalCode(DateTime IGeboorteDatum)
        {
            return IGeboorteDatum.Year.ToString();
        }
        public string MaakGebruikersnaam(string INaam, string IVoorNaam, DateTime IGeboorteDatum)
        {
            string FamNaamcode = MaakFamNaamCode(INaam);
            string VoorNaamCode = MaakVoorNaamCode(IVoorNaam);
            string JaartalCode = MaakJaartalCode(IGeboorteDatum);

            return FamNaamcode + VoorNaamCode + JaartalCode;
        }


    }
}
