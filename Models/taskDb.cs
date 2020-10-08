using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks.Models
{
    public class taskDb
    {
        public int Id { get; set; }
        public string Title { get; set; } // Title of the Task
        public bool Status { get; set; } // The current status of the task
        public string Version { get; set; } // Which version this task apply to
        public int Priority { get; set; } // 0 = Not set, 1 = Low, 2 = Medium, 3 = High
        public string Deadline { get; set; } // Set the date and time for deadline
        public string Date { get; set; } // When the task was issued.

    }
}
