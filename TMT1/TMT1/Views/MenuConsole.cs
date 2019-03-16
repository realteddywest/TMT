
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
            Console.Write("Choose command: ");
            return Console.ReadLine();

        }
        public string MenuRead()
        {
            Console.WriteLine("1 - Country info");
            Console.WriteLine("2 - Town info");
            Console.Write("Choose command: ");
            return Console.ReadLine();

        }
    }
}
