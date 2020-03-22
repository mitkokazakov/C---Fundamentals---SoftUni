using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            List<Students> listOfStudents = new List<Students>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] inputStudentsData = Console.ReadLine().Split();
                string firstName = inputStudentsData[0];
                string lastName = inputStudentsData[1];
                double grade = double.Parse(inputStudentsData[2]);

                Students students = new Students(firstName, lastName, grade);

                listOfStudents.Add(students);

            }

            listOfStudents = listOfStudents.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, listOfStudents));
        }
    }
}
