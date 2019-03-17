
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT1.Views
{
    public class MenuConsole
    {
        public string MenuInsert()
        {
            Console.WriteLine("1 - Add Country");
            Console.WriteLine("2 - Add Town");
            Console.WriteLine("3 - Add Agent");
            Console.WriteLine("4 - Add Criminal");
            Console.WriteLine("0 - Back");
            Console.Write("Choose command: ");
            return Console.ReadLine();

        }
        //Basic menu
        public string MenuRead()
        {
            Console.WriteLine("1 - Countries info");
            Console.WriteLine("2 - Towns info");
            Console.WriteLine("3 - Agents basic info");
            Console.WriteLine("4 - Agents full info");
            Console.WriteLine("5 - Criminals info");
            Console.WriteLine("0 - Back");
            Console.Write("Choose command: ");
            return Console.ReadLine();

        }
        public string Menu()
        {
            Console.WriteLine("1 - Print");
            Console.WriteLine("2 - Add");
            Console.WriteLine("3 - ");
            Console.WriteLine("4 - ");
            
            Console.Write("Choose command: ");
            return Console.ReadLine();

        }
    }
}
