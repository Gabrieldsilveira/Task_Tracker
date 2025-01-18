using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Tracker.Models;

namespace Task_Tracker.Services
{
    internal class ListService
    {
        public static void List(string inputUser)
        {
            if (string.IsNullOrWhiteSpace(inputUser))
            {
                ListAllTask();
            }
            else if (inputUser.Equals("done", StringComparison.OrdinalIgnoreCase))
            {
                ListAllDoneTask();
            }
            else if (inputUser.Equals("todo", StringComparison.OrdinalIgnoreCase))
            {
                ListAllTodoTask();
            }
            else if (inputUser.Equals("in-progress", StringComparison.OrdinalIgnoreCase))
            {
                ListAllInProgressTask();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"ERRO: Comando \"{inputUser.ToLower()}\" não reconhecido, tente novamente.");
            }
        }

        public static void ListAllTask()
        {
            Console.WriteLine("\n**Lista de todas as tarefas**\n");
            foreach (var task in DataRepository.taskList)
            {
                Console.WriteLine($"ID: {task.Id}\nDESCRIÇÃO: {task.Description}\nSTATUS: {task.Status}\n" +
                    $"CRIADA DIA: {task.CreatedAt}\nATUALIZADA DIA: {task.UpdatedAt}\n");
            }
        }

        public static void ListAllTodoTask()
        {
            Console.WriteLine("\n**Lista de todas as tarefas**\n");
            foreach (var task in DataRepository.taskList)
            {
                if (task.Status.Equals("todo", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"ID: {task.Id}\nDESCRIÇÃO: {task.Description}\nSTATUS: {task.Status}\n" +
                    $"CRIADA DIA: {task.CreatedAt}\nATUALIZADA DIA: {task.UpdatedAt}\n");
                }            
            }
        }

        public static void ListAllDoneTask()
        {
            Console.WriteLine("\n**Lista de todas as tarefas**\n");
            foreach (var task in DataRepository.taskList)
            {
                if (task.Status.Equals("done", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"ID: {task.Id}\nDESCRIÇÃO: {task.Description}\nSTATUS: {task.Status}\n" +
                    $"CRIADA DIA: {task.CreatedAt}\nATUALIZADA DIA: {task.UpdatedAt}\n");
                }
            }
        }

        public static void ListAllInProgressTask()
        {
            Console.WriteLine("\n**Lista de todas as tarefas**\n");
            foreach (var task in DataRepository.taskList)
            {
                if (task.Status.Equals("in-progress", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"ID: {task.Id}\nDESCRIÇÃO: {task.Description}\nSTATUS: {task.Status}\n" +
                    $"CRIADA DIA: {task.CreatedAt}\nATUALIZADA DIA: {task.UpdatedAt}\n");
                }
            }
        }
    }
}
