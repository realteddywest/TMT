using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT1.Controllers
{
    public class DeleteController
    {
        private TMTContext context;
        public DeleteController(TMTContext context)
        {
            this.context = context;
        }
        public bool DeleteAgent(int agentId)
        {
            var agent = context.Agents.FirstOrDefault(a => a.Id == agentId);
            if (agent != null)
            {
                agent.Criminals.Clear();
                context.Agents.Remove(agent);
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
