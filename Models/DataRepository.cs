using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_Tracker.Models
{
    public static class DataRepository
    {
        public static List<Tasks> taskList = new List<Tasks>();

        public static void LoadTasks()
        {
            string path = "C:\\Program Files (x86)\\Programação\\C#\\Task Tracker\\Task Tracker\\Documents\\TasksJson.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    DataRepository.taskList = JsonSerializer.Deserialize<List<Tasks>>(json) ?? new List<Tasks>();
                }
                else
                {
                    DataRepository.taskList = new List<Tasks>();
                }
                
            }
        }
    }
}
