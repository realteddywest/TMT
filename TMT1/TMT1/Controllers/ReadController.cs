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
            return context.Countries.ToList();
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
    }
}
