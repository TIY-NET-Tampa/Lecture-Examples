using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Services
{
    public class UserAction
    {
        public int NumberToDelete { get; set; } = -1;
        public string TaskToAdd { get; set; }
        public Actions ActionToTake { get; set; }
    }
}
