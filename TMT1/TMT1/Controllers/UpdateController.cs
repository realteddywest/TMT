using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT1.Controllers
{
    public class UpdateController
    {
        private TMTContext context;
        public UpdateController(TMTContext context)
        {
            this.context = context;
        }

        public bool UpdateAgentNickname(int id, string newNickname)
        {
            var agent = context.Agents.FirstOrDefault(a => a.Id == id);
            if (agent != null)
            {
                agent.Nickname = newNickname;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool GrwoAgent(int id)
        {
            var agent = context.Agents.FirstOrDefault(a => a.Id == id);
            if (agent != null)
            {
                agent.Age++;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UpdateCriminalStatus(int id, string newStatus)
        {
            var criminal = context.Criminals.FirstOrDefault(c => c.Id == id);
            if (criminal != null)
            {
                criminal.Status = newStatus;
               context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateCriminalSentence(int id, string newSentence)
        {
            var criminal = context.Criminals.FirstOrDefault(c => c.Id == id);
            if (criminal != null)
            {
                criminal.Sentence = newSentence;
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
