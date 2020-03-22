using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Company_Roster
{
    class Employee
    {
        public Dictionary<double, string> EmployeeData { get; set; }
        public List<double> Salary { get; set; }
        public string Department { get; set; }
        public double AverageSalary { get; set; }

        public Employee()
        {
            
            this.EmployeeData = new Dictionary<double, string>();
            this.Salary = new List<double>();
            
        }

        public double CalculateAverageSalary()
        {
            double avrgSalary = this.Salary.Sum() / this.Salary.Count;

            return avrgSalary;
        }
    }
}
