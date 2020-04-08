using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> course = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] courseInfo = input.Split(" : ");

                string courseName = courseInfo[0];
                string studentName = courseInfo[1];

                if (!course.ContainsKey(courseName))
                {
                    course[courseName] = new List<string>();
                }

                course[courseName].Add(studentName);

                input = Console.ReadLine();
            }

            foreach (var singleCourse in course.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{singleCourse.Key}: {singleCourse.Value.Count}");

                foreach (var student in singleCourse.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
