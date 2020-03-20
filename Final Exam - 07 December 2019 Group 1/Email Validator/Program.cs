using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Complete")
            {
                string[] commandArgs = commands.Split();

                string mainCommand = commandArgs[0];

                if (mainCommand == "Make")
                {
                    email = ChangeMailToLowerOrUpper(email, commandArgs);
                }
                else if (mainCommand == "GetDomain")
                {
                    GetDomainOfEmail(email, commandArgs);
                }
                else if (mainCommand == "GetUsername")
                {
                    GetUsernameOfEmail(email);
                }
                else if (mainCommand == "Replace")
                {
                    email = ReplaceCertainCharWithDash(email, commandArgs);
                }
                else if (mainCommand == "Encrypt")
                {
                    GetASCIIValueOfEachChar(email);
                }
                commands = Console.ReadLine();
            }

        }

        private static void GetASCIIValueOfEachChar(string email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                int currentASCII = email[i];
                Console.Write(currentASCII + " ");
            }
            Console.WriteLine();
        }

        private static string ReplaceCertainCharWithDash(string email, string[] commandArgs)
        {
            char ch = Convert.ToChar(commandArgs[1]);

            while (email.Contains(ch))
            {
                email = email.Replace(ch, '-');
            }
            Console.WriteLine(email);
            return email;
        }

        private static void GetUsernameOfEmail(string email)
        {
            if (!email.Contains('@'))
            {
                Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
            }
            else
            {
                int index = email.IndexOf("@");
                string name = email.Substring(0, index);
                Console.WriteLine(name);
            }
        }

        private static void GetDomainOfEmail(string email, string[] commandArgs)
        {
            int count = int.Parse(commandArgs[1]);
            string lastChars = email.Substring(email.Length - count, count);
            Console.WriteLine(lastChars);
        }

        private static string ChangeMailToLowerOrUpper(string email, string[] commandArgs)
        {
            if (commandArgs[1] == "Upper")
            {
                email = email.ToUpper();
                Console.WriteLine(email);
            }
            else if (commandArgs[1] == "Lower")
            {
                email = email.ToLower();
                Console.WriteLine(email);
            }

            return email;
        }
    }
}
