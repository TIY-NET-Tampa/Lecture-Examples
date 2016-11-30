using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Services
{
    public class Task
    {
        public Task()
        {
            // default
        }
        public Task(string[] line)
        {
            this.Description = line[0];
            this.TimeCreated = DateTime.Parse(line[1]);
        }

        public Guid Id { get; set; } = Guid.NewGuid();

        public string Description { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;

        public string ToCSVString()
        {
            return $"{Description}, {TimeCreated}";
        }

        public override string ToString()
        {
            return $"{Description}";
        }
    }
}
