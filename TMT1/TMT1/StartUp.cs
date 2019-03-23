using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMT1.Controllers;

namespace TMT1
{
    class StartUp
    {
        static void Main(string[] args)
        {
          // ConsoleController controller = new ConsoleController();

            TMTContext context = new TMTContext();
            DeleteController d = new DeleteController(context);
            UpdateController u = new UpdateController(context);
           // u.UpdateCriminalStatus(9, "Dead");
            u.UpdateCriminalSentence(9, "15 life terms of imprisonment - 957 years total");


        }
    }
}
