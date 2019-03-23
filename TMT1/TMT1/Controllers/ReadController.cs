using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT1.Controllers
{
    public class ReadController
    {
        private TMTContext context;

        public ReadController(TMTContext context)
        {
            this.context = context;
        }

        public List<Country> CountriesList()
        {
            return context.Countries.OrderBy(c=>c.Name).ToList();
        }

        public List<Town> TownsList()
        {
            return context.Towns.OrderBy(t=>t.Name).ToList();
        }

        public List<Agent> AgentsList()
        {
            return context.Agents.ToList();
        }

        public List<Criminal> CriminalsList()
        {
            return context.Criminals.ToList();
        }

        public Country FindCountry(string countryName)
        {
            Country find = context.Countries.FirstOrDefault(x => x.Name == countryName);
            return find;
        }

        //Method find town
        public Town FindTown(string countryName, string townName)
        {
            Country findCountry = FindCountry(countryName);
            if (findCountry == null)
            {
                return null;
            }
            else
            {
                Town find = context.Towns.Where(x => x.Name == townName && x.Country.Name ==
                countryName).
                FirstOrDefault();
                return find;
            }
        }
    }
}
