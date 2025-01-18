using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Task_Tracker.Models;

namespace Task_Tracker.Services
{
    internal class DeleteService
    {
        public static void Delete(string taskId)
        {
            int taskIdInt;

            bool success = int.TryParse(taskId, out taskIdInt);
            if (success)
            {
                var taskToDelete = DataRepository.taskList.FirstOrDefault(t => t.Id == taskIdInt);

                if (taskToDelete != null)
                {
                    DataRepository.taskList.Remove(taskToDelete);

                    string serialize = JsonSerializer.Serialize(DataRepository.taskList, new JsonSerializerOptions { WriteIndented = true });
                    string path = "C:\\Program Files (x86)\\Programação\\C#\\Task Tracker\\Task Tracker\\Documents\\TasksJson.json";
                    File.WriteAllText(path, serialize);
                    Console.WriteLine($"Task Excluida com sucesso (ID: {taskId})");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"ERRO: O ID: {taskId} não existe, tente novamente.");
                }              
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"O ID: {taskId} não foi reconhecido, tente um id válido.(ex:1, 2, 3...)");
            }
        }
    }
}
