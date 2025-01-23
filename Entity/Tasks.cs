using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.Entity
{
    public class Tasks
    {
        public Tasks(int id, string description, string status, string createdAt)
        {
            Id = id;
            Description = description;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public Tasks()
        {

        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
