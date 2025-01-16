using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_Tracker.Services
{
    public class InputHandler
    {
        public static (string command, string information) UserInputHandler(string userInput)
        {
            string[] parts = userInput.Split(' ', 2);

            string command = parts[0];
            string information = "";

            if (parts.Length > 1 && parts.Length < 3)
            {
                information = parts[1];
            }

            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            information = textInfo.ToTitleCase(information);

            return (command, information);
        }

        public static (int taskId,  string information) UpdateInputHandler (string userInput)
        {
            string[] parts = userInput.Split(" ", 2);

            string taskId = parts[0];
            string information = "";
            int taskIdToInt;

            bool success = int.TryParse(taskId, out taskIdToInt);
            if (success)
            {
                if (parts.Length > 1 && parts.Length < 3)
                {
                    information = parts[1];
                }
            }
            else
            {
                taskIdToInt = 0;
            }
            
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            information = textInfo.ToTitleCase(information);

            return (taskIdToInt, information);
        }
    }
}
