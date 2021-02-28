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

                Console.Write("Do you want add one more task (y/n)?");
                newTask = Console.ReadKey().KeyChar;
                Console.Write("\n\n");

                if (!newTask.Equals('y'))
                {
                    break;
                }
            }

            foreach (Task task in tasks)
            {
                task.GetTask();
            }
            Console.ReadKey();
        }
    }
}
