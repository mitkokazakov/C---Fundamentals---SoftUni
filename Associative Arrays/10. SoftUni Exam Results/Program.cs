using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> count = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] studentsInfo = input.Split("-");

                if (studentsInfo[1] == "banned")
                {
                    string name = studentsInfo[0];

                    if (results.ContainsKey(name))
                    {
                        results.Remove(name);
                    }
                }
                else
                {
                    string name = studentsInfo[0];
                    string courseName = studentsInfo[1];
                    int points = int.Parse(studentsInfo[2]);

                    if (!results.ContainsKey(name))
                    {
                        results[name] = 0;
                    }

                    if (points > results[name])
                    {
                        results[name] = points;
                    }

                    if (!count.ContainsKey(courseName))
                    {
                        count[courseName] = 0;
                    }
                    count[courseName]++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var student in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var course in count.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{course.Key} - {course.Value}");
            }
        }
    }
}
