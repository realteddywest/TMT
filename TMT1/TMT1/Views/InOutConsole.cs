using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT1.Views
{
    public class InOutConsole
    {
        public string ReadCountryName()
        {
            Console.WriteLine("Въведи име на държава: ");
            return Console.ReadLine();
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public string ReadTownName()
        {
            Console.WriteLine("Въведи име на град: ");
            return Console.ReadLine();
        }

    }
}
