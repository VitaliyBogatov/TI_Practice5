using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            char newTask = 'y';

            ArrayList tasks = new ArrayList();


            while (newTask.Equals('y'))
            {
                Console.Write("Please add a task.");
                Console.Write("\nTaskName: ");
                String tskName = Console.ReadLine();

                Task tsk = new Task();

                if (tskName.Length != 0)
                {
                    tsk.SetTask(tskName);
                }
                else
                {
                    Console.Write("\nSpecified task's name cannot be empty.");
                }

                tasks.Add(tsk);

                Console.Write("\nDo you want add one more task (y/n)?");
                newTask = Console.ReadKey().KeyChar;
                Console.Write("\n\n");

                if (!newTask.Equals('y'))
                {
                    break;
                }
            }

            //foreach (Task task in tasks)
            //{
            //    task.GetTask();
            //}

            Console.Write("Please choose an action:" +
                "\n1. Count total hours by all tasks." +
                "\n2. Return all tasks by priority." +
                "\n3. Tasks those can be done in N days by priority."+
                "\nPlease choose an option... ");

            char action = Console.ReadKey().KeyChar;

            switch (action)
            {
                case '1':
                    decimal totalTime = 0;
                    foreach (Task task in tasks)
                    {
                        totalTime += task.GetTime();
                    }
                    Console.Write($"\nTotal time for all tasks execution is {totalTime}");
                    break;
            }

            Console.ReadKey();
        }
    }
}
