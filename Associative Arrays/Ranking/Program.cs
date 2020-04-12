using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwords = new Dictionary<string, string>();

            string inputPasswords = Console.ReadLine();

            while (inputPasswords != "end of contests")
            {
                string[] pass = inputPasswords.Split(":");
                string contestName = pass[0];
                string currentPassword = pass[1];

                if (!passwords.ContainsKey(contestName))
                {
                    passwords[contestName] = " ";
                }

                passwords[contestName] = currentPassword;

                inputPasswords = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();
            string submissionInput = Console.ReadLine();

            while (submissionInput != "end of submissions")
            {
                string[] submInfo = submissionInput.Split("=>");
                string courseName = submInfo[0];
                string coursePass = submInfo[1];
                string studentName = submInfo[2];
                int points = int.Parse(submInfo[3]);

                if (passwords.ContainsKey(courseName) && passwords[courseName] == coursePass)
                {
                    if (!results.ContainsKey(studentName))
                    {
                        results[studentName] = new Dictionary<string, int> { { courseName, points } };
                    }
                    

                    if (!results[studentName].ContainsKey(courseName))
                    {
                        results[studentName].Add(courseName, points);
                    }
                    if (results[studentName][courseName] < points)
                    {
                        results[studentName][courseName] = points;
                    }
                }

                

                submissionInput = Console.ReadLine();
            }

            var bestPoints = new Dictionary<string, int>();

            foreach (var item in results)
            {
                bestPoints[item.Key] = item.Value.Values.Sum();
            }

            string topName = bestPoints.Keys.Max();
            int topPoints = bestPoints.Values.Max();

            Console.WriteLine($"Best candidate is {topName} with total {topPoints} points.");

            Console.WriteLine("Ranking: ");

            foreach (var item in results.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
