﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT1.Views
{
    
    public class MenuConsole
    {
        //------------------------------Insert menu------------------------------

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

        //------------------------------Basic menu-------------------------------

        public string MenuRead()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("1 - Countries info");
            Console.WriteLine("2 - Towns info");
            Console.WriteLine("3 - Agents basic info");
            Console.WriteLine("4 - Agents full info");
            Console.WriteLine("5 - Criminals basic info");
            Console.WriteLine("6 - Criminals full info");
            Console.WriteLine("0 - Back");
            Console.Write("Choose command: ");
            return Console.ReadLine();
        }

        //------------------------------Menu Delete------------------------------

        public string MenuDelete()
        {          
            Console.WriteLine("1 - Delete agent");
            Console.WriteLine("2 - Delete criminal");
            Console.WriteLine("0 - Back");
            Console.Write("Choose command: ");
            return Console.ReadLine();
        }

        //------------------------------Menu Update------------------------------

        public string MenuUpdate()
        {
            Console.WriteLine("1 - Update agent nickname");
            Console.WriteLine("2 - Grow agent");
            Console.WriteLine("3 - Update criminal status");
            Console.WriteLine("4 - Update criminal sentence");
            Console.WriteLine("0 - Back");
            Console.Write("Choose command: ");
            return Console.ReadLine();
        }

        //-------------------------------Menu------------------------------------

        public string Menu()
        {
            Console.WriteLine("1 - Print");
            Console.WriteLine("2 - Add");
            Console.WriteLine("3 - Delete");
            Console.WriteLine("4 - Update");
            Console.WriteLine(" ");
            Console.Write("Choose command: ");
            return Console.ReadLine();
        }

        //------------------------------------------------------------------------
    }
}
