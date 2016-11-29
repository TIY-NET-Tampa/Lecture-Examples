using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Services;

namespace ToDoListSolution
{
    class Program
    {
        public static TaskList MyList { get; set; } = new TaskList();
        public static void DisplayTaskList()
        {
            Console.WriteLine("Current Tasks");
            Console.WriteLine("---------------");
            for (int i = 0; i < MyList.Tasking.Count; i++)
            {
                var item = MyList.Tasking[i];
                Console.WriteLine($"{i + 1} - {item.Description} : {item.TimeCreated.ToShortTimeString()}");
            }
        }

        public static void DisplayCompletedTasks()
        {
            Console.WriteLine("Completed Tasks");
            Console.WriteLine("---------------");
            for (int i = 0; i < MyList.CompletedTasks.Count; i++)
            {
                var item = MyList.CompletedTasks[i];
                Console.WriteLine($"{i + 1} - {item.Description} : {item.TimeCreated.ToShortTimeString()}");
            }
        }

        public static void DisplayList(string header, List<Task> listToDisplay, string lineBreak = "---------------")
        {
            Console.WriteLine(header);
            Console.WriteLine(lineBreak);
            if (listToDisplay.Count == 0)
            {
                Console.WriteLine("Nothing on this list!");
            }
            else
            {
                for (int i = 0; i < listToDisplay.Count; i++)
                {
                    var item = listToDisplay[i];
                    Console.WriteLine($"{i + 1} - {item.Description} : {item.TimeCreated.ToShortTimeString()}");
                }

            }
        }
        public static UserAction GetUserAction()
        {
            Console.WriteLine("Type a task to add it or enter the number to complete the task:");
            Console.WriteLine("Type 'save' to save and exit");
            var input = Console.ReadLine();
            var num = 0;
            var isNumber = int.TryParse(input, out num);
            var rv = new UserAction();
            if (isNumber)
            {
                // we know its to remove
                rv.NumberToDelete = num - 1;
                rv.ActionToTake = Actions.Delete;
            }
            else
            {
                if (String.Compare(input, "save", true) == 0)
                {
                    rv.ActionToTake = Actions.SaveAndExit;
                }
                else
                {
                    // we are adding
                    rv.TaskToAdd = input;
                    rv.ActionToTake = Actions.Add;
                }

            }
            return rv;
        }

        static void Main(string[] args)
        {
            var error = new ErrorMessage();
            var working = true;
            MyList.LoadFromFile();
            while (working)
            {
                Console.Clear();
                if (error.ShouldDisplay)
                {
                    Console.WriteLine(error.Message);
                }
                error.ShouldDisplay = true;
                // Display the list
                DisplayList("What i like", MyList.Tasking);
                DisplayList("Completed Tasks", MyList.CompletedTasks, "************");
                // Ask the user what to do (add)
                var userAction = GetUserAction();
                switch (userAction.ActionToTake)
                {
                    case (Actions.Delete):
                        // we are removing
                        error.ShouldDisplay = MyList.RemoveItemFromList(userAction.NumberToDelete);
                        if (error.ShouldDisplay)
                        {
                            error.Message = "Item does not exists, try again";
                        }
                        break;
                    case (Actions.Add):
                        // we are adding
                        MyList.AddItemToList(userAction.TaskToAdd);
                        break;
                    case (Actions.SaveAndExit):
                        Console.WriteLine("Saving....");
                        MyList.SaveList();
                        working = false;
                        break;
                }
            }
            Console.ReadLine();
        }

    }
}
