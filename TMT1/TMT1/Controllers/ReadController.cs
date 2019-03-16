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

        public List<Country> CoutriesList()
        {
            return context.Countries.ToList();
        }
    }
}
