using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ToDoList.Services
{
    public class TaskList
    {
        public List<Task> Tasking { get; set; } = new List<Task>();
        public List<Task> CompletedTasks { get; set; } = new List<Task>();

        public void AddItemToList(string newTask)
        {
            Tasking.Add(new Task { Description = newTask });
        }

        public bool RemoveItemFromList(int itemToRemove)
        {
            var wasRemoved = true;
            if (itemToRemove > Tasking.Count)
            {
                // we know the item doesnt 
                wasRemoved = false;
            }
            else
            {
                var item = Tasking[itemToRemove];
                CompletedTasks.Add(item);
                Tasking.RemoveAt(itemToRemove);
            }
            return wasRemoved;
            
        }
    }
}
