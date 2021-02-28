
using System;

namespace TI_Practice5
{
    class TaskEnums{

        public enum TaskPriority
        {
            High = 1,
            Medium = 2,
            Low = 3
        }

        public enum TaskSeverity
        {
            Major = 1,
            Moderate = 2,
            Low = 3
        }

        public enum TaskExecutionPeriod
        {
            Complex = 8,
            Middle = 4,
            Trivial = 2
        }

        public static string GetSeverities()
        {
            string severity = "";
            var names = Enum.GetNames(typeof(TaskEnums.TaskSeverity));

            int i = 1;
            foreach (var el in names)
            {
                if (names.Length > i)
                {   
                    severity += el+",";
                    i++;
                }
                else
                {
                    severity += el;
                }
            }
            return severity;
        }

        public static string GetPriorities()
        {
            string priority = "";
            var names = Enum.GetNames(typeof(TaskEnums.TaskPriority));

            int i = 0;
            foreach (var el in names)
            {
                if (names.Length - 1 != i)
                {
                    priority += el + ",";
                    i++;
                }
                else
                {
                    priority += el;
                }
            }
            return priority;
        }
        public static string GetExecutioPeriods()
        {
            string execution = "";
            var names = Enum.GetNames(typeof(TaskEnums.TaskExecutionPeriod));

            int i = 0;
            foreach (var el in names)
            {
                if (names.Length - 1 != i)
                {
                    execution += el + ",";
                    i++;
                }
                else
                {
                    execution += el;
                }
            }
            return execution;
        }
    }
}
