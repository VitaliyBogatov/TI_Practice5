using System;
using static TI_Practice5.TaskEnums;

namespace TI_Practice5
{
    public class Task
    {
        public string TaskName { get; set; }
        public TaskPriority Priority { get; set; }
        public TaskSeverity Severity { get; set; }
        public TaskExecutionPeriod ExecutionTime { get; set; }



        public void Add()
        {
            Console.Write($"\nSelect the {TaskName} task's severity:{TaskEnums.GetSeverities()}\nPlease choose...");

            while (Severity == TaskSeverity.Undefined)
            {
                String severity = Console.ReadLine();
                Severity = TaskEnums.ValidateSeverity(severity);
            }

            Console.Write($"\nSelect the {TaskName} task's priority:{TaskEnums.GetPriorities()}\nPlease choose...");

            TaskEnums.TaskPriority tskPriority = TaskEnums.TaskPriority.Undefined;
            while (Priority == TaskPriority.Undefined)
            {
                String priority = Console.ReadLine();
                Priority = TaskEnums.VaidatePriority(priority);
            }

            Console.Write($"\nSelect the {TaskName} task's execution time:{TaskEnums.GetExecutioPeriods()}\nPlease choose...");

            while (ExecutionTime == TaskExecutionPeriod.Undefined)
            {
                String executionTime = Console.ReadLine();
                ExecutionTime = TaskEnums.ValidateExecutionTime(executionTime);
            }
        }

        public void ShowDetails()
        {
            
            Console.Write($"\nTask name: {TaskName}."+
                    $"\n\tPriority: {Priority}."+
                    $"\n\tSeverity: {Severity}."+
                    $"\n\tTime: {ExecutionTime}.");
        }

        public decimal GetTime()
        {
            decimal time = Convert.ToDecimal(ExecutionTime);
            return time;
        }

        public void GetByPriority(int priority)
        {

        }
    }
}
