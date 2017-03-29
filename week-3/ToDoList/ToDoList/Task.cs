using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Task
    {
       
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public Task()
        {
            CreatedDate = DateTime.Now;
        }

        public Task(string line)
        {
            var split = line.Split(',');
            this.Name = split[0];
            this.CreatedDate = DateTime.Parse(split[1]);
        }

        public override string ToString()
        {
            return $"{Name},{CreatedDate}";
        }
    }
}
