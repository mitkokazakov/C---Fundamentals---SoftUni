using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> academy = new Dictionary<string, List<double>>();

            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!academy.ContainsKey(name))
                {
                    academy[name] = new List<double>();
                }

                academy[name].Add(grade);
            }

            foreach (var student in academy.Where(x => x.Value.Average() >= 4.50).OrderByDescending(y => y.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
