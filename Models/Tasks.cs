using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.Models
{
    public class Tasks
    {
        public Tasks(int id, string description, string status, DateTime createdAt, DateTime updatedAt)
        {
            id = Id;
            description = Description;
            status = Status;
            createdAt = CreatedAt;
            updatedAt = UpdatedAt;
        }

        public Tasks()
        {

        }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
