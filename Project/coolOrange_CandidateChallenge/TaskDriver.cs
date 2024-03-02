using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coolOrange_CandidateChallenge
{
    class TaskDriver
    {
        private static readonly List<Task> TasksList = new List<Task>();
        static void Main(string[] args)
        {
            TasksList.Add(new Task("Doing Homework", 10, 8));
            TasksList.Add(new Task("Eating Lunch", 1, 2));
            TasksList.Add(new Task("Programming", 5, 5));

            Console.WriteLine(Print());
        }

        private static string Print()
        {
            var sb = new StringBuilder();
            
            sb.AppendLine("TO-DO");
            sb.AppendLine("---------");
            foreach (var task in TasksList)
            {
                sb.AppendLine(task.Print());
            }

            var mostImportantTask = TasksList.Max();

            sb.Append(mostImportantTask.GetName());
            sb.AppendLine(" is one of the most important tasks");

            return sb.ToString();
        }
    }
}