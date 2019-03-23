using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMT1.Controllers;
using TMT1.Forms;

namespace TMT1
{
    class StartUp
    {
        static void Main(string[] args)
        {
           //ConsoleController controller = new ConsoleController();

            TMTContext context = new TMTContext();
            DeleteController d = new DeleteController(context);
            UpdateController u = new UpdateController(context);
            // u.UpdateCriminalStatus(9, "Dead");
            // u.UpdateCriminalSentence(9, "15 life terms of imprisonment - 957 years total");
            //u.UpdateAgentNickname(13, "Coco");

            Application.EnableVisualStyles();

            Application.Run(new FormReadTownInfo());
            
        }
    }
}
