
using System;

namespace TI_Practice5
{
    public class TaskEnums{

        public enum TaskPriority
        {
            Undefined = 0,
            High = 1,
            Medium = 2,
            Low = 3
        }

        public enum TaskSeverity
        {
            Undefined = 0,
            Major = 1,
            Moderate = 2,
            Low = 3
        }

        public enum TaskExecutionPeriod
        {
            Undefined = 0,
            Trivial = 2,
            Middle = 4,
            Complex = 8
        }

        public static string GetSeverities()
        {
            string name;
            string severity = "";
            Array names = Enum.GetValues(typeof(TaskEnums.TaskSeverity));

            foreach (int value in names)
            {
                if (value != TaskSeverity.Undefined.GetHashCode())
                {
                    name = Enum.GetName(typeof(TaskEnums.TaskSeverity), value);
                    severity += $"\n- {name}: {value}.";
                }
            }
            return severity;
        }

        public static string GetPriorities()
        {
            string name;
            string priority = "";
            Array names = Enum.GetValues(typeof(TaskEnums.TaskPriority));

            foreach (int value in names)
            {
                if (value != TaskPriority.Undefined.GetHashCode())
                {
                    name = Enum.GetName(typeof(TaskEnums.TaskPriority), value);
                    priority += $"\n- {name}: {value}.";
                }
            }
            return priority;
        }
        public static string GetExecutioPeriods()
        {
            string name;
            string execution = "";
            Array names = Enum.GetValues(typeof(TaskExecutionPeriod));

            foreach (int value in names)
            {
                if (value != TaskExecutionPeriod.Undefined.GetHashCode())
                {
                    name = Enum.GetName(typeof(TaskExecutionPeriod), value);
                    execution += $"\n- {name}: {value} hours.";
                }
            }
            return execution;
        }

        public static TaskPriority VaidatePriority(string priority)
        {
                try
                {
                    TaskPriority tskPriority = (TaskPriority)Enum.Parse(typeof(TaskPriority), priority, true);
                    if (!Enum.IsDefined(typeof(TaskPriority), tskPriority) || tskPriority == TaskPriority.Undefined)
                    {
                        Console.Write($"{priority} is not an underlying value of the Priority enumeration. Please set a valid value: ");
                        return TaskPriority.Undefined;
                    }
                    else
                    {
                        return tskPriority;
                    }
                }
                catch (ArgumentException)
                {
                    Console.Write("{0} is not a member of the Priority enumeration. Please set a valid value: ", priority);
                    return TaskPriority.Undefined;
                }
        }

         public static TaskSeverity ValidateSeverity(string severity)
         {
            try
            {
                TaskSeverity tskSeverity = (TaskSeverity)Enum.Parse(typeof(TaskSeverity), severity, true);
                if (!Enum.IsDefined(typeof(TaskSeverity), tskSeverity) || tskSeverity == TaskSeverity.Undefined)
                {
                    Console.Write($"{severity} is not an underlying value of the Severity enumeration. Please set a valid value: ");
                    return TaskSeverity.Undefined;
                }
                else
                {
                    return tskSeverity;
                }
            }
            catch (ArgumentException)
            {
                Console.Write("{0} is not a member of the Severity enumeration. Please set a valid value: ", severity);
                return TaskSeverity.Undefined;
            }
         }

        public static TaskExecutionPeriod ValidateExecutionTime(string executionTime)
        {
            try
            {
                TaskExecutionPeriod tskExecutionTime = (TaskExecutionPeriod)Enum.Parse(typeof(TaskExecutionPeriod), executionTime, true);
                if (!Enum.IsDefined(typeof(TaskExecutionPeriod), tskExecutionTime) || tskExecutionTime == TaskExecutionPeriod.Undefined)
                {
                    Console.Write($"{executionTime} is not an underlying value of the ExexutionPeriod enumeration. Please set a valid value: ");
                    return TaskExecutionPeriod.Undefined;
                }
                else
                {
                    return tskExecutionTime;
                }
            }
            catch (ArgumentException)
            {
                Console.Write("{0} is not a member of the ExexutionPeriod enumeration. Please set a valid value: ", executionTime);
                return TaskExecutionPeriod.Undefined;
            }
        }
    }
}
