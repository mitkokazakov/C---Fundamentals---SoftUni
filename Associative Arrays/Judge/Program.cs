using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualResults = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] info = input.Split(" -> ");
                string studentName = info[0];
                string contestName = info[1];
                int points = int.Parse(info[2]);


                if (!results.ContainsKey(contestName))
                {
                    results[contestName] = new Dictionary<string, int>();
 
                }

                if (!results[contestName].ContainsKey(studentName))
                {
                    results[contestName].Add(studentName, points);
                    //individualResults[studentName] = points;
                }
                

                if (results[contestName].ContainsKey(studentName))
                {
                    if (results[contestName][studentName] < points)
                    {
                        results[contestName][studentName] = points;
                        //individualResults[studentName] += points;
                    }
                }




                input = Console.ReadLine();
            }

            foreach (var contest in results)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");

                int counter = 0;

                foreach (var student in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {student.Key} <::> {student.Value}");
                }
            }

            Console.WriteLine("Individual standings: ");

            foreach (var contest in results)
            {
                foreach (var student in contest.Value)
                {
                    if (!individualResults.ContainsKey(student.Key))
                    {
                        individualResults[student.Key] = student.Value;
                    }
                    else
                    {
                        individualResults[student.Key] += student.Value;
                    }
                    
                }
            }


            int counter1 = 0;

            foreach (var student in individualResults.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter1++;

                Console.WriteLine($"{counter1}. {student.Key} -> {student.Value}");
            }
        }
    }
}
