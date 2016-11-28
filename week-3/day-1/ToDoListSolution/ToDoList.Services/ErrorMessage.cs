using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Services
{
    public class ErrorMessage
    {
        public bool ShouldDisplay { get; set; } = false;
        public string  Message { get; set; }
    }
}
