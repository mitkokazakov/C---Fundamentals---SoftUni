using System;
using System.Linq;
using System.Collections.Generic;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < numOfEmployees; i++)
            {
                string[] infoEmployee = Console.ReadLine().Split();

                string name = infoEmployee[0];
                double salary = double.Parse(infoEmployee[1]);
                string department = infoEmployee[2];

                

                Employee existingDepartment = employeeList.Find(x => x.Department == department);
                Employee employee = new Employee();

                if (existingDepartment == null)
                {
                    employee.Department = department;
                    employee.EmployeeData.Add(salary, name);
                    employee.Salary.Add(salary);
                    employeeList.Add(employee);
                }
                else if (existingDepartment != null)
                {
                    existingDepartment.EmployeeData.Add(salary, name);
                    existingDepartment.Salary.Add(salary);
                    employeeList.Add(employee);
                }
            }

            foreach (Employee employee in employeeList)
            {
                double avrgSalary = employee.CalculateAverageSalary();
                employee.AverageSalary = avrgSalary;
            }

            Employee bestAverageSalary = employeeList.OrderByDescending(x => x.AverageSalary).ThenBy(x => x.Salary).First();

            Console.WriteLine($"Highest Average Salary: {bestAverageSalary.Department}");

            foreach (var employee in bestAverageSalary.EmployeeData.OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"{employee.Value} {employee.Key}");
            }
            

                
            
            
            
        }
    }
}
