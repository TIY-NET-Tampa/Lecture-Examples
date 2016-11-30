using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace ToDoList.Services
{
    public class TaskList
    {
        public List<Task> Tasking { get; set; } = new List<Task>();
        public List<Task> CompletedTasks { get; set; } = new List<Task>();

        private string filePath = "tasks.csv";

        public void AddItemToList(string newTask)
        {
            Tasking.Add(new Task { Description = newTask });
        }

        public bool RemoveItemFromList(Task task)
        {
            var itemToRemove = Tasking.FirstOrDefault(f => f.Id == task.Id);
            if (itemToRemove != null)
            {
                Tasking.Remove(itemToRemove);
            }
            return true;
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

        public void SaveList()
        {
            using (var sw = new StreamWriter(filePath))
            {
                foreach (var task in Tasking)
                {
                    sw.WriteLine(task.ToCSVString());
                }
            }
        }

     
        public void LoadFromFile()
        {
            Tasking.Clear();
            if (File.Exists(filePath))
            {
                using (var sr = new StreamReader(filePath))
                {
                    while (sr.Peek() > 0)
                    {
                        var line = sr.ReadLine().Split(',');
                        var newTask = new Task(line);
                        Tasking.Add(newTask);
                    }
                }
            } 

        }

    }
}
