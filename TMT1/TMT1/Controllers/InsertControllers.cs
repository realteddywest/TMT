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
        private TMTContext context ;
        private ReadController find;

        public InsertController(TMTContext context)
        {
            this.context = context;
            this.find = new ReadController(context);
        }    

        // INSERT COUNTRIES
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

        //INSERT TOWNS
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

        //INSERT AGENTS
        public bool InsertIntoAgents(string agentName, string agentNickName, int agentAge, string townName, string countryName)
        {
            InsertIntoTowns(townName, countryName);
            Town fTown = find.FindTown(countryName, townName);
            Agent newAgent = new Agent(agentName, agentNickName, agentAge, fTown.Id);
            context.Agents.Add(newAgent);
            context.SaveChanges();
            return true;
        }

        //INSERT CRIMINALS
        public bool InsertIntoCriminals(string criminalName, string criminalNickName, string townName, string countryName, string crime, string sentence, string status, string evilnessFactor)
        {
            InsertIntoTowns(townName, countryName);
            Town fTown = find.FindTown(countryName, townName);
            Criminal newCriminal = new Criminal(criminalName,criminalNickName, fTown.Id, crime, sentence, status, evilnessFactor);
            context.Criminals.Add(newCriminal);
            context.SaveChanges();
            return true;
        }

    }
}
