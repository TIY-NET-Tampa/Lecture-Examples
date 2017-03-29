using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {

        const string path = "task.csv";
        static void SaveTasks(List<Task> tasks)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var task in tasks)
                {
                    writer.WriteLine(task);
                }
            }
        }
        public static List<Task> ReadTasksFromFile()
        {
            var rv = new List<Task>();
            using (var reader = new StreamReader(path))
            {
                while(reader.Peek() > -1)
                {
                    var line = reader.ReadLine();
                    rv.Add(new Task(line));
                }
            }
            return rv;
        }

        static void DisplayTasks(List<Task> tasks)
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
        static void Main(string[] args)
        {
            var tasks = ReadTasksFromFile();
            DisplayTasks(tasks);
            Console.WriteLine("add a task?:");
            var input = Console.ReadLine();
            var newtask = new Task() { Name = input };
            tasks.Add(newtask);
            DisplayTasks(tasks);
            SaveTasks(tasks);

        }
    }
}
