using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMT1.Controllers;

namespace TMT1.Controllers
{
    public class InsertController
    {
        private static TMTContext context = new TMTContext();

        private static Find find = new Find();

        public bool InsertIntoCountries(string countryName)
        {
            if (find.FindCountry(countryName) == null)
            {
                context.Countries.Add(new Country() { Name = countryName });
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool InsertIntoTowns(string townName, string countryName)
        {
            Town findTown = find.FindTown(countryName, townName);
            if (findTown == null)
            {
                InsertIntoCountries(countryName);
                Town newTown = new Town()
                {
                    Name = townName,
                    CountryCode = find.FindCountry(countryName).Id
                };
                context.Towns.Add(newTown);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
