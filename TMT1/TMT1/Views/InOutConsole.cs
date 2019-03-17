using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT1.Views
{
    public class InOutConsole
    {
        public void Line(char c,int Lenght)
        {
            Console.WriteLine(new string(c,Lenght));
        }

        public string ReadCountryName()
        {
            Console.WriteLine("Enter country name: ");
            return Console.ReadLine();
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadTownName()
        {
            Console.WriteLine("Enter town name: ");
            return Console.ReadLine();
        }

        public string ReadAgentName()
        {
            Console.WriteLine("Enter agent name: ");
            return Console.ReadLine();
        }

        public string ReadAgentNick()
        {
            Console.WriteLine("Enter agent nickname: ");
            return Console.ReadLine();
        }

        public int ReadAge()
        {
            Console.WriteLine("Enter age: ");
            return int.Parse(Console.ReadLine());
        }

        //----------------------------
        public string ReadCriminalName()
        {
            Console.WriteLine("Enter criminal name : ");
            return Console.ReadLine();
        }

        public string ReadCriminalNick()
        {
            Console.WriteLine("Enter criminal nickname: ");
            return Console.ReadLine();
        }

        public string ReadCrime()
        {
            Console.WriteLine("Enter crime: ");
            return Console.ReadLine();
        }

        public string ReadSentence()
        {
            Console.WriteLine("Enter sentence: ");
            return Console.ReadLine();
        }

        public string ReadStatus()
        {
            Console.WriteLine("Enter status: ");
            return Console.ReadLine();
        }

        public string ReadEvilnessFactor()
        {
            Console.WriteLine("Enter evilness factor: ");
            return Console.ReadLine();
        }


        //--------------------------------
        public void PrintCountriesInfo(List<Country> coutries)
        {
            Console.WriteLine($"{"ID",-4}{"Country name",-15}");
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

        public void PrintAgentsInfo(List<Agent> agents)
        {
            Console.WriteLine($"{"ID",-4}{"Agent name",-15}");
            foreach (var a in agents)
            {
                Console.WriteLine($"{a.Id,-4}{a.Name,-15}");
            }
        }

        public void PrintCriminalsInfo(List<Criminal> criminals)
        {
            Console.WriteLine($"{"ID",-4}{"Town name",-15}");
            foreach (var c in criminals)
            {
                Console.WriteLine($"{c.Id,-4}{c.Name,-15}");
            }
        }

        public void PrintFullAgentsInfo(List<Agent> agents)
        {
            Console.WriteLine($"{"ID",-4}{"Agent name",-30}{"Nickname",-17}{"Age",-15}{"TownId",-5}");
            foreach (var a in agents)
            {
                Console.WriteLine($"{a.Id,-4}{a.Name,-30}{a.Nickname,-17}{a.Age,-15}{a.TownId,-5}");               
            }
        }

        public void PrintFullCriminalsInfo(List<Criminal> criminals)
        {
            Console.WriteLine("Info");
            foreach (var c in criminals)
            {
                Line('_', Console.BufferWidth);
                PrintFullCriminalInfo(c);
                    }
        }

        public void PrintFullCriminalInfo(Criminal c)
        {
            Console.WriteLine($"ID - {c.Id}");
            Console.WriteLine($"Name - {c.Name}");
            Console.WriteLine($"Nickname - {c.Nickname}");
            Console.WriteLine($"TownId - {c.TownId}");
            Console.WriteLine($"Crime info - {c.Crime}");
            Console.WriteLine($"Sentence - {c.Sentence}");
            Console.WriteLine($"Status - {c.Status}");
            Console.WriteLine($"EvilnessFactor - {c.EvilnessFactor.Name}");
        }

        public void DeleteAgents(List<Agent> agents)
        {
            Console.WriteLine("This agent was deleted");
        }


    }
}
