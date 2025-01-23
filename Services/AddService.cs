using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Tracker.Models;
using System.Text.Json;
using Task_Tracker.Entity;

namespace Task_Tracker.Services
{
    internal class AddService
    {
        public static void Add(string task)
        {
            int listCount = DataRepository.taskList.Count;
            int id = listCount + 1;
            string atualDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            Tasks newTask = new Tasks(id: id, description: task, status: "todo", createdAt: atualDate);
            DataRepository.taskList.Add(newTask);

            string serialize = JsonSerializer.Serialize(DataRepository.taskList, new JsonSerializerOptions { WriteIndented = true });
            string path = "C:\\Program Files (x86)\\Programação\\C#\\Task Tracker\\Task Tracker\\Documents\\TasksJson.json";
            
            File.WriteAllText(path, serialize);
        }

        public static void CallAddFunction(string information)
        {
            if (!string.IsNullOrEmpty(information))
            {
                AddService.Add(information);
                Console.Clear();
                Console.WriteLine($"Task adicionada com sucesso (ID: {DataRepository.taskList.Count})");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERRO: É necessário adicionar uma descrição à tarefa.");
            }
            
        }
    }
}
