using System;

namespace _04.Password_Validator
{
    class Program
    {
        static bool CheckLength(string input)
        {
            return input.Length >= 6 && input.Length <= 10;
        }

        static bool ContainsLetterOrDigits(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetterOrDigit(input[i]))
                {
                    return false;
                }
                
                
            }
            return true;
        }

        static bool MinDigits(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    counter++;
                }
            }

            return counter >= 2;
        }


        static void Main(string[] args)
        {
            string inputPass = Console.ReadLine();

            if (!CheckLength(inputPass))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!ContainsLetterOrDigits(inputPass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!MinDigits(inputPass))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            
        }
    }
}
