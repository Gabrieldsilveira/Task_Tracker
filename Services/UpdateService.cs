using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Task_Tracker.Models;

namespace Task_Tracker.Services
{
    internal class UpdateService
    {
        public static void update(int taskId, string newDescription)
        {
            var taskToUpdate = DataRepository.taskList.FirstOrDefault(task => task.Id == taskId);

            if (taskToUpdate != null)
            {
                taskToUpdate.Description = newDescription;
                taskToUpdate.UpdatedAt = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERRO: A tarefa selecionada não existe.");
            }
            string serialize = JsonSerializer.Serialize(DataRepository.taskList, new JsonSerializerOptions { WriteIndented = true });
            string path = "C:\\Program Files (x86)\\Programação\\C#\\Task Tracker\\Task Tracker\\Documents\\TasksJson.json";
            File.WriteAllText(path, serialize);
        }

        public static void CallUpdateFunction(string information)
        {
            var updateInputHandler = InputHandler.UpdateInputHandler(information);

            if (updateInputHandler.taskId < 1 || updateInputHandler.taskId > DataRepository.taskList.Count)
            {
                Console.Clear();
                Console.WriteLine("ERRO: É necessário informar um Id válido/existente para alterar.");
            }
            else if (!string.IsNullOrWhiteSpace(updateInputHandler.information))
            {
                UpdateService.update(updateInputHandler.taskId, updateInputHandler.information);
                Console.Clear();
                Console.WriteLine($"Task modificada com sucesso (ID: {updateInputHandler.taskId})");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERRO: É necessário adicionar uma descrição para atualizar.");
            }
        }

        public static void UpdateTaskId()
        {
            foreach(var task in DataRepository.taskList)
            {
                int idToChange = DataRepository.taskList.IndexOf(task);
                if (idToChange == -1)
                {
                    Console.Clear();
                    Console.WriteLine("ERRO: O programa será reiniciado devido a um problema inesperado.");
                    MainUI.MainUi();
                }
                else
                {
                    if (idToChange == 0)
                    {
                        task.Id = 1;
                    }
                    else
                    {
                        task.Id = idToChange + 1;
                    }
                    string serialize = JsonSerializer.Serialize(DataRepository.taskList, new JsonSerializerOptions { WriteIndented = true });
                    string path = "C:\\Program Files (x86)\\Programação\\C#\\Task Tracker\\Task Tracker\\Documents\\TasksJson.json";
                    File.WriteAllText(path, serialize);
                }
            }
        }
    }
}
