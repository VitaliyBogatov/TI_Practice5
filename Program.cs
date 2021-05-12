using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TI_Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            char action = ' ';

            while (action != 'q')
            {
                //Clear console
                Console.Clear();

                Console.Write("Please choose an action from the list:" +
                           "\n1. Add tasks." +
                           "\n2. Get tasks." +
                           "\n3. Clear tasks." +
                           "\n4. Count total hours by all tasks." +
                           "\n5. Return all tasks by priority." +
                           "\n6. Return tasks those can be done in N days by priority." +
                           "\nPlease choose an option or cick 'q' to finish work....  ");

                action = Console.ReadKey().KeyChar;
                
                if ((Regex.Match(action.ToString(), "[1-6]|q").Success))
                {
                    switch (action)
                    {

                        //Add tasks with priority, severity and execution time
                        case '1':
                            char newTask = 'y';

                            while (newTask.Equals('y'))
                            {
                                Console.Write("\n\nPlease add a task.");
                                Console.Write("\nTaskName: ");
                                String tskName = Console.ReadLine();

                                Task task = new Task();

                                if (tskName.Length != 0)
                                {
                                    task.Add();
                                    task.TaskName = tskName;
                                    tasks.Add(task);
                                }
                                else
                                {
                                    Console.Write("\nSpecified task's name cannot be empty.");
                                }

                                Console.Write("\nDo you want add one more task (y/n)?");
                                newTask = Console.ReadKey().KeyChar;
                                Console.Write("\n\n");

                                if (!newTask.Equals('y'))
                                {
                                    break;
                                }
                            }
                            Console.ReadKey();
                            break;

                        //Get all tasks
                        case '2':
                            if (tasks.Count != 0)
                            {
                                Console.Write("\n\nThe list of added tasks.");
                                foreach (Task task in tasks)
                                {
                                    
                                    task.ShowDetails();
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.Write("\n\nTasks are absent.\n");
                            }
                            Console.ReadKey();
                            break;

                        //Clear all tasks
                        case '3':
                            tasks.Clear();
                            Console.Write("\n\nTasks have been deleted.\n");
                            Console.ReadKey();
                            break;

                        //Calculate the total time of all tasks execution
                        case '4':
                            if (tasks.Count != 0)
                            {
                                decimal totalTime = 0;

                                foreach (Task task in tasks)
                                {
                                    totalTime += task.GetTime();
                                }
                                Console.Write($"\nTotal time for all tasks execution is {totalTime} hours.");
                            }
                            else
                            {
                                Console.Write("\nTasks are absent.");
                            }
                            Console.ReadKey();
                            break;

                        case '5':
                            Console.Write($"\nSet the task' priority: {TaskEnums.GetPriorities()} ");

                            string priority = Console.ReadLine();
                            TaskEnums.TaskPriority tskPriority = TaskEnums.VaidatePriority(priority);

                            IEnumerable<Task> tasksByPriority = tasks.Where(task => task.Priority == tskPriority);

                            if (tasksByPriority.Count() != 0)
                            {
                                Console.Write($"\n\n{tasksByPriority.Count()} task(s) having {tskPriority} priority.");
                                foreach (Task task in tasksByPriority)
                                {
                                    task.ShowDetails();
                                }
                            }
                            else
                            {
                                Console.Write("\n\nTasks are absent.\n");
                            }
                            Console.ReadKey();
                            break;

                        case '6':
                            if (tasks.Count != 0)
                            {
                                int days = 0;
                                int hours = 0;

                                Console.Write($"\n\nSpecify the number of days: ");

                                bool valid = false;
                                while (!valid)
                                {
                                    var input = Console.ReadLine();
                                    if (int.TryParse(input, out days) && days > 0)
                                    {
                                        hours = days * 8;
                                        valid = true;
                                    }
                                    else
                                    {
                                        Console.Write("\nSpecify a valid value: ");
                                    }
                                }

                                IEnumerable<Task> query = tasks.OrderBy(task => task.Priority).ThenByDescending(task => task.ExecutionTime);

                                Console.WriteLine("The list of tasks that can be fully done during {0} day(s):", days);

                                foreach (Task task in query)
                                {
                                    if (hours >= task.ExecutionTime.GetHashCode())
                                    {
                                        hours -= task.ExecutionTime.GetHashCode();
                                        Console.WriteLine("Task {0} having the {1} priority must be done during {2} hours.", task.TaskName, task.Priority, task.ExecutionTime.GetHashCode());
                                    }
                                }
                            }
                            else
                            {
                                Console.Write("\n\nTasks are absent.");
                            }
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    //Clear console
                    Console.Clear();
                    continue;
                }
            }
            

            Console.ReadKey();
        }
    }
}
