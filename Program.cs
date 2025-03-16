using System;

namespace ToDoListManager
{
    class Program
    {
        // Define a list to store tasks
        static List<string> toDoList = new List<string>();

        // Main method
        static void Main(string[] args)
        {   
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("___To-Do List Manager___");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1. Add task to list");
                Console.WriteLine("2. Remove task from list");
                Console.WriteLine("3. Mark task as complete");
                Console.WriteLine("4. View task list");
                Console.WriteLine("5. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        addTask();
                        break;
                    case "2":
                        removeTask();
                        break;
                    case "3":
                        completeTask();
                        break;
                    case "4":
                        viewTasks();
                        break;
                    case "5":
                        Console.WriteLine("Exiting program");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid menu option (1, 2, 3, 4, 5)");
                        break;
                }
            }            
        }

        static void addTask()
        {
            Console.WriteLine();
            Console.WriteLine("___Adding task to list___");
            Console.Write("Task name: ");
            toDoList.Add(Console.ReadLine());
            Console.WriteLine("Task successfully added to the list.");
            Console.WriteLine();
        }

        static void removeTask()
        {            
            if (toDoList.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No tasks in list to remove");
                Console.WriteLine("Try adding a task first");
                Console.WriteLine();
                return;
            }
            
            while (true)
            {
                viewTasks();
                Console.WriteLine("Which task do you want to remove?");
                if (!int.TryParse(Console.ReadLine(), out int taskSelect))
                {
                    Console.WriteLine("Please enter a valid task number");
                    continue;
                }
                if (taskSelect < 1 || taskSelect > toDoList.Count)
                {
                    Console.WriteLine("Please enter a valid task number");
                    continue;
                }
                else
                {
                    taskSelect--;
                    Console.WriteLine();
                    Console.WriteLine($"You've selected task \"{taskSelect + 1}. {toDoList[taskSelect]}\", confirm this is the correct task?");
                    Console.WriteLine("1. Yes, delete that task.");
                    Console.WriteLine("2. No, wrong task");
                    if (!int.TryParse(Console.ReadLine(), out int userInput))
                    {
                        Console.WriteLine("Please select a valid option (1 or 2)");
                        continue;
                    }
                    if (userInput == 1)
                    {
                        Console.WriteLine($"{taskSelect + 1}. {toDoList[taskSelect]} successfully deleted");
                        Console.WriteLine();
                        toDoList.RemoveAt(taskSelect);                    
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No tasks deleted, returning to main menu");
                        Console.WriteLine();
                        break;
                    }
                }
                                
            }            
        }
        static void completeTask()
        {
            if (toDoList.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No tasks in list to mark complete");
                Console.WriteLine("Try adding a task first");
                Console.WriteLine();
                return;
            }
            
            while (true)
            {
                Console.WriteLine();
                viewTasks();
                Console.WriteLine("Which task would you like to mark as completed?");
                if (!int.TryParse(Console.ReadLine(), out int taskSelect))
                {
                    Console.WriteLine("Please enter a valid task number");
                    continue;
                }
                
                if (taskSelect < 1 || taskSelect > toDoList.Count)
                {
                    Console.WriteLine("Please enter a valid task number");
                    continue;
                }
                else
                {
                    taskSelect--;
                    if (toDoList[taskSelect].EndsWith("[Completed]"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Task already marked as complete");
                        Console.WriteLine();
                        break;
                    }
                    toDoList[taskSelect] = toDoList[taskSelect] + " [Completed]";
                    Console.WriteLine($"{taskSelect + 1}. {toDoList[taskSelect]} marked as complete");
                    break;
                }               
            }           
        }
        static void viewTasks()
        {
            Console.WriteLine();
            Console.WriteLine("___Task List___");
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {toDoList[i]}");
            }
            Console.WriteLine();
        }
    }
}

