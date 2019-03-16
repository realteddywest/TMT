
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT1.Views
{
    public class MessageApp
    {
        public string MessageInsertCountryTrue(string countryName)
        {
            string message = $"{countryName} was added successfully!";
            return message;
        }

        public string MessageInsertCountryFalse(string countryName)
        {
            string message = $"{countryName} already exists!";
            return message;
        }
        public string MessageInsertTownTrue(string countryName, string townName)
        {
            string message = $"To country'{countryName}' was added town named '{townName}'!";
            return message;
        }

        public string MessageInsertTownFalse(string countryName, string townName)
        {
            string message = $" In '{countryName}' already exists a town named '{townName}'!";
            return message;
        }

        public string MessageInsertAgentTrue()
        {
            string message = $"New agent added!";
            return message;
        }
        public string MessageInsertCriminalTrue()
        {
            string message = $"New criminal added!";
            return message;
        }

    }
}
