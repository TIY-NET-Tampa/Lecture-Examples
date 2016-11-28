using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Services
{
    public class Task
    {
        public string Description { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
    }
}
