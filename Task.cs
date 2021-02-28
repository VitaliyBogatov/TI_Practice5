using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Practice5
{
    public class Task
    {
        string tskName;
        TaskEnums.TaskSeverity tskSeverity = new TaskEnums.TaskSeverity();
        TaskEnums.TaskPriority tskPriority = new TaskEnums.TaskPriority();
        TaskEnums.TaskExecutionPeriod tskExecutionTime = new TaskEnums.TaskExecutionPeriod();

        public Task()
        {
        }

        public void SetTask(String tskName)
        {
            this.tskName = tskName;
            Console.Write($"Set the {tskName} task's severity ({TaskEnums.GetSeverities()}): ");

            string severity = "";

            while (severity.Equals(""))
            {
                severity = Console.ReadLine();

                try
                {
                    tskSeverity = (TaskEnums.TaskSeverity)Enum.Parse(typeof(TaskEnums.TaskSeverity), severity);
                    if (!Enum.IsDefined(typeof(TaskEnums.TaskSeverity), severity))
                    {
                        Console.Write($"{severity} is not an underlying value of the Severity enumeration. Please set a valid value: ");
                        severity = "";
                    }
                }
                catch (ArgumentException)
                {
                    Console.Write("{0} is not a member of the Severity enumeration. Please set a valid value: ", severity);
                    severity = "";
                }
            }
            

            Console.Write($"\nSet the {tskName} task's priority ({TaskEnums.GetPriorities()}): ");

            string priority = "";

            while (priority.Equals(""))
            {
                priority = Console.ReadLine();
                
                try
                {
                    tskPriority = (TaskEnums.TaskPriority)Enum.Parse(typeof(TaskEnums.TaskPriority), priority);
                    if (!Enum.IsDefined(typeof(TaskEnums.TaskPriority), priority))
                    {
                        Console.Write($"{priority} is not an underlying value of the Priority enumeration. Please set a valid value: ");
                        priority = "";
                    }
                }
                catch (ArgumentException)
                {
                    Console.Write("{0} is not a member of the Priority enumeration. Please set a valid value: ", priority);
                    priority = "";
                }
            }

            Console.Write($"\nSet the {tskName} task's severity ({TaskEnums.GetExecutioPeriods()}): ");
            string executionTime = "";

            while (executionTime.Equals(""))
            {
                executionTime = Console.ReadLine();

                try
                {
                    tskExecutionTime = (TaskEnums.TaskExecutionPeriod)Enum.Parse(typeof(TaskEnums.TaskExecutionPeriod), executionTime);
                    if (!Enum.IsDefined(typeof(TaskEnums.TaskExecutionPeriod), executionTime))
                    {
                        Console.Write($"{executionTime} is not an underlying value of the ExecutionPeriod enumeration. Please set a valid value: ");
                        executionTime = "";
                    }
                }
                catch (ArgumentException)
                {
                    Console.Write("{0} is not a member of the ExecutionPeriod enumeration. Please set a valid value: ", executionTime);
                    executionTime = "";
                }
            }
        }

        public void GetTask()
        {
            Console.WriteLine($"Task name: {tskName}.");
            Console.WriteLine($"Task priority: {Enum.Parse(typeof(TaskEnums.TaskPriority), tskPriority.ToString())}.");
            Console.WriteLine($"Task severity: {Enum.Parse(typeof(TaskEnums.TaskSeverity), tskSeverity.ToString())}.");
            Console.WriteLine($"Task execution time: {Enum.Parse(typeof(TaskEnums.TaskExecutionPeriod), tskExecutionTime.ToString())}.");
        }
    }
}
