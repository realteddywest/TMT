using TMT1.Views;
using TMT1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMT1.Forms;

namespace TMT1.Controllers
{
    public class ConsoleController
    {
        public static TMTContext context = new TMTContext();

        public static InsertController insert = new InsertController(context);

        public static InOutConsole inOut = new InOutConsole();

        public static MessageApp message = new MessageApp();

        public static MenuConsole menu = new MenuConsole();

        public static ReadController read = new ReadController(context);

        DeleteController delete = new DeleteController(context);

        UpdateController update = new UpdateController(context);

        //----------Menu------------
        public ConsoleController()
        {
            Menu();
        }

        public void Menu()
        {
            while (true)
            {
                inOut.Line('-', Console.BufferWidth);
                switch (menu.Menu())
                {
                    case "1":
                        Read();
                        break;
                    case "2":
                        Create();
                        break;
                    case "3":
                        Delete();
                        break;
                    case "4":
                        Update();
                        break;
                    case "5":
                        Application.EnableVisualStyles();
                        Application.Run(new FormMain(context, insert, read, update, delete));
                        break;
                    default: return;
                       
                }
            }
        }

        //-----------------------
        public void Create()
        {
            inOut.Line('-', Console.BufferWidth);
            while (true)
            {
                switch (menu.MenuInsert())
                {
                    case "1":
                        InsertIntoCountries();
                        break;
                    case "2":
                        InserIntoTowns();
                        break;
                    case "3":
                        InsertIntoAgents();
                        break;
                    case "4":
                        InsertIntoCriminals();
                        break;
                    case "0":
                        Menu();
                        break;
                    default: return;
                }
            }

        }
 
        public void Read()
        {
            inOut.Line('-', Console.BufferWidth);
            while (true)
            {
                switch (menu.MenuRead())
                {
                    case "1":
                        PrintCountriesInfo();
                        break;
                    case "2":
                        PrintTownsInfo();
                        break;
                    case "3":
                        PrintAgentsInfo();
                        break;
                    case "4":
                        PrintFullAgentsInfo();
                        break;
                    case "5":
                        PrintCriminalsInfo();
                        break;
                    case "6":
                        PrintFullCriminalsInfo();
                        break;
                    case "0":
                        Menu();
                        break;
                    default: return;
                }
            }
        }

        public void Delete()
        {
            inOut.Line('-', Console.BufferWidth);
            while (true)
            {
                inOut.Line('-', Console.BufferWidth);
                switch (menu.MenuDelete())
                {
                    case "1":
                        DeleteAgent();
                        break;
                    case "2":
                        DeleteCriminal();
                        break;                     
                    case "0":
                        Menu();
                        break;
                    default: return;
                }
            }
        }

        public void Update()
        {
            inOut.Line('-', Console.BufferWidth);
            while (true)
            {
                inOut.Line('-', Console.BufferWidth);
                switch (menu.MenuUpdate())
                {
                    case "1":
                        UpdateAgentNickname();
                        break;
                    case "2":
                        GrowAgent();
                        break;
                    case "3":
                        UpdateCriminalStatus();
                        break;
                    case "4":
                        UpdateCriminalSentence();
                        break;
                    case "0":
                        Menu();
                        break;
                    default: return;
                }
            }
        }

        //----------------------------INSERT----------------------
        public void InsertIntoCountries()
        {
            string countryName = inOut.ReadCountryName();
            bool isAdd = insert.InsertIntoCountries(countryName);
            if (isAdd == true)
            {
                inOut.PrintMessage(message.MessageInsertCountryTrue(countryName));
            }
            else
            {
                inOut.PrintMessage(message.MessageInsertCountryFalse(countryName));
            }
        }

        public void InserIntoTowns()
        {
            string countryName = inOut.ReadCountryName();
            string townName = inOut.ReadTownName();
            bool isAdd = insert.InsertIntoTowns(townName, countryName);
            if (isAdd == true)
            {
                inOut.PrintMessage(message.MessageInsertTownTrue
                    (countryName, townName));
            }
            else
            {
                inOut.PrintMessage(message.MessageInsertTownFalse
                    (countryName, townName));
            }
        }

        public void InsertIntoAgents()
        {
            string agentName = inOut.ReadAgentName();
            string agentNickName = inOut.ReadAgentNick();
            int agentAge = inOut.ReadAge();
            string townName = inOut.ReadTownName();
            string countryName = inOut.ReadCountryName();
            insert.InsertIntoAgents(agentName, agentNickName, agentAge, townName, countryName);
            inOut.PrintMessage(message.MessageInsertAgentTrue());
        }

        public void InsertIntoCriminals()
        {
            string criminalName = inOut.ReadCriminalName();
            string criminalNickName = inOut.ReadCriminalNick();
            string townName = inOut.ReadTownName();
            string countryName = inOut.ReadCountryName();
            string crime = inOut.ReadCrime();
            string sentence = inOut.ReadSentence();
            string status = inOut.ReadStatus();
            string evilnessFactor = inOut.ReadEvilnessFactor();
            insert.InsertIntoCriminals(criminalName, criminalNickName, townName, countryName, crime, sentence, status, evilnessFactor);
            inOut.PrintMessage(message.MessageInsertCriminalTrue());
        }


        //------------------------------PRINT--------------------------
        public void PrintCountriesInfo()
        {
            inOut.PrintCountriesInfo(read.CountriesList());
        }

        public void PrintTownsInfo()
        {
            inOut.PrintTownsInfo(read.TownsList());
        }

        public void PrintAgentsInfo()
        {
            inOut.PrintAgentsInfo(read.AgentsList());
        }

        public void PrintCriminalsInfo()
        {
            inOut.PrintCriminalsInfo(read.CriminalsList());
            inOut.Line('-', Console.BufferWidth);
        }

        public void PrintFullAgentsInfo()
        {
            inOut.PrintFullAgentsInfo(read.AgentsList());
            inOut.Line('-', Console.BufferWidth);
        }

        public void PrintFullCriminalsInfo()
        {
            inOut.PrintFullCriminalsInfo(read.CriminalsList());
            inOut.Line('-', Console.BufferWidth);
        }

        //------------------------------DELETE--------------------------
        public void DeleteAgent()
        {
            var id = inOut.ReadId();
            bool isRemove = delete.DeleteAgent(id);
            if (isRemove)
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void DeleteCriminal()
        {
            Console.WriteLine(delete.DeleteCriminal());
        }

        //------------------------------UPDATE--------------------------
        public void UpdateAgentNickname()
        {
            var id = inOut.ReadId();
            var newNickname = inOut.ReadAgentNick();
            bool isUpdated = update.UpdateAgentNickname(id, newNickname);

            if (isUpdated)
            {
                inOut.Line(' ', Console.BufferWidth);
                Console.WriteLine("Successfully updated");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void GrowAgent()
        {
            var id = inOut.ReadId();
            
            bool isUpdated = update.GrowAgent(id);

            if (isUpdated)
            {
                inOut.Line(' ', Console.BufferWidth);
                Console.WriteLine("Successfully updated agent's age");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void UpdateCriminalStatus()
        {
            var id = inOut.ReadId();
            var newStatus = inOut.ReadStatus();
            bool isUpdated = update.UpdateCriminalStatus(id, newStatus);

            if (isUpdated)
            {
                inOut.Line(' ', Console.BufferWidth);
                Console.WriteLine("Successfully updated");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void UpdateCriminalSentence()
        {
            var id = inOut.ReadId();
            var newSentence = inOut.ReadSentence();
            bool isUpdated = update.UpdateCriminalSentence(id, newSentence);

            if (isUpdated)
            {
                inOut.Line(' ', Console.BufferWidth);
                Console.WriteLine("Successfully updated");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }

}

