using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            int counter = 0;

            string pattern = @"[U][$]([A-Z]{1}[a-z]{2,})[U][$][P][@][$]+([A-Za-z]{5,}[0-9]+)[P][@][$]";

            for (int i = 0; i < numOfLines; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(pattern);
                var matches = regex.Match(input);

                if (!matches.Success)
                {
                    Console.WriteLine("Invalid username or password");
                }
                else
                {
                    counter++;
                    string username = matches.Groups[1].Value;
                    string pass = matches.Groups[2].Value;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {pass}");
                }
            }

            Console.WriteLine($"Successful registrations: {counter}");
        }
    }
}
