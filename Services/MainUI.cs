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
            DataRepository.LoadTasks();

            Console.Clear();
            Console.WriteLine("Bem vindo ao Task Tracker!\nDigite \"help\" para ver os comandos.");
            Console.Write("task-cli ");

            string userInput = Console.ReadLine().ToLower();           
            (string inputHandlerCommand, string inputHandlerInfo) = InputHandler.UserInputHandler(userInput);
            
            switch(inputHandlerCommand)
            {
                case "add":
                    AddService.CallAddFunction(inputHandlerInfo);
                    break;
                case "update":
                    UpdateService.CallUpdateFunction(inputHandlerInfo);
                    break;
                case "delete":
                    DeleteService.Delete(inputHandlerInfo);
                    break;
                case "mark":
                    MarkService.Mark(inputHandlerInfo);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"ERRO: \"{inputHandlerCommand}\" não foi reconhecido, tente \"help\" para ver todos os comandos.");
                    break;
            }
        }
    }
}
