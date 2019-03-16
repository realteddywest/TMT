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
        public string ReadAgentName()
        {
            Console.WriteLine("Въведи име на агент: ");
            return Console.ReadLine();
        }
        public string ReadAgentNick()
        {
            Console.WriteLine("Въведи псевдоним на агент: ");
            return Console.ReadLine();
        }
        public int ReadAge()
        {
            Console.WriteLine("Въведи години: ");
            return int.Parse(Console.ReadLine());
        }
        public void PrintCoutriesInfo(List<Country> coutries)
        {
            Console.WriteLine($"{"ID",-4}{"Coutry name",-15}");
            foreach (var c in coutries)
            {
                Console.WriteLine($"{c.Id,-4}{c.Name,-15}");
            }
        }

        public void PrintTownsInfo(List<Town> towns)
        {
            Console.WriteLine($"{"ID",-4}{"Town name",-15}");
            foreach (var t in towns)
            {
                Console.WriteLine($"{t.Id,-4}{t.Name,-15}");
            }
        }
    }
}
