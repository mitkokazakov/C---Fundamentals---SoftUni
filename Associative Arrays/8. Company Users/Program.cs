using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] companyInfo = input.Split(" -> ");
                string companyName = companyInfo[0];
                string companyID = companyInfo[1];

                if (!company.ContainsKey(companyName))
                {
                    company[companyName] = new List<string>();
                }

                if (!company[companyName].Contains(companyID))
                {
                    company[companyName].Add(companyID);
                }

                input = Console.ReadLine();
            }

            foreach (var singleCompany in company.OrderBy(x => x.Key))
            {
                Console.WriteLine(singleCompany.Key);

                foreach (var employeeID in singleCompany.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
