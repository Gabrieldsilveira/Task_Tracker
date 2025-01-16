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
                Console.WriteLine($"Task updated successfully (ID: {updateInputHandler.taskId})");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERRO: É necessário adicionar uma descrição para atualizar.");
            }
        }
    }
}
