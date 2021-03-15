using System;
using System.Collections.Generic;

namespace Kordamine_Bob_EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo>todos = new List<Todo>()
            {
                new Todo(){Description = "Task 1", EstimatedHours = 6, Status = Status.Completed},
                new Todo(){Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress}
            };

            PrintAssessment(todos);
            Console.ReadLine();
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case Status.OnHold:
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }

    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }

    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}
