using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Task_Tracker.Models;

namespace Task_Tracker.Services
{
    internal class MarkService
    {
        public static void Mark(string userInput)
        {
            var MarkInputHandler = InputHandler.UpdateInputHandler(userInput);
            var taskToUpdate = DataRepository.taskList.FirstOrDefault(task => task.Id == MarkInputHandler.taskId);

            bool informationIsValid = MarkInputHandler.information.Equals("in-progress", StringComparison.OrdinalIgnoreCase)
                || MarkInputHandler.information.Equals("done", StringComparison.OrdinalIgnoreCase)
                || MarkInputHandler.information.Equals("todo", StringComparison.OrdinalIgnoreCase);

            if (taskToUpdate != null && informationIsValid)
            {     
                taskToUpdate.Status = MarkInputHandler.information;
                taskToUpdate.UpdatedAt = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Console.WriteLine("Task modificada com sucesso");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERRO: A tarefa não existe ou o comando está incorreto.\nDigite \"help\" para mais informações.");
            }
            string serialize = JsonSerializer.Serialize(DataRepository.taskList, new JsonSerializerOptions { WriteIndented = true });
            string path = "C:\\Program Files (x86)\\Programação\\C#\\Task Tracker\\Task Tracker\\Documents\\TasksJson.json";
            File.WriteAllText(path, serialize);
        }
    }
}
