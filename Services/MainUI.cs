using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Tracker.Models;

namespace Task_Tracker.Services
{
    public class MainUI
    {
        public static void MainUi()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Task Tracker!\nDigite \"help\" para ver os comandos.");

            string userInput = Console.ReadLine().ToLower();
            
            var result = InputHandler.UserInputHandler(userInput);
            Console.WriteLine(result.command);
            Console.WriteLine(result.information);
        }
    }
}
