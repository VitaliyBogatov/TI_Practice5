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
        string tskSeverity;
        string tskPriority;
        string tskExecutionTime;

        public Task()
        {
        }

        public void SetTask(String tskName)
        {
            this.tskName = tskName;
            Console.Write($"Set the {tskName} task's severity ({TaskEnums.GetSeverities()}): ");
            string severity = Console.ReadLine();
            tskSeverity = severity;

            Console.Write($"Set the {tskName} task's priority ({TaskEnums.GetPriorities()}): ");
            string priority = Console.ReadLine();
            tskPriority = priority;

            Console.Write($"Set the {tskName} task's severity ({TaskEnums.GetExecutioPeriods()}): ");
            string executionTime = Console.ReadLine();
            tskExecutionTime = executionTime;
        }

        public void GetTask()
        {
            Console.WriteLine($"Task name: {tskName}.");
            Console.WriteLine($"Task priority: {Enum.Parse(typeof(TaskEnums.TaskPriority), tskPriority)}.");
            Console.WriteLine($"Task severity: {Enum.Parse(typeof(TaskEnums.TaskSeverity), tskSeverity)}.");
            Console.WriteLine($"Task execution time: {Enum.Parse(typeof(TaskEnums.TaskExecutionPeriod), tskExecutionTime)}.");
        }
    }
}
