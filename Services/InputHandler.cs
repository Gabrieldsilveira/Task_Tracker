using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.Services
{
    public class InputHandler
    {
        public static (string command, string information) UserInputHandler(string userInput)
        {
            string[] parts = userInput.Split(' ', 2);

            string command = parts[0];
            string information = parts[1].Length > 1? parts[1] : "";

            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            information = textInfo.ToTitleCase(information);

            return (command, information);
        }
    }
}
