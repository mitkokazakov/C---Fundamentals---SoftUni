using System;

namespace _09.Palindrome_Integers
{
    class Program
    {
        static void PrintPalindrome(string input)
        {
            string newString = "";

            for (int i = input.Length-1; i >= 0; i--)
            {
                newString += input[i];
            }

            int originalNum = int.Parse(input);
            int reversedNum = int.Parse(newString);

            if (originalNum == reversedNum)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                
                PrintPalindrome(input);
                input = Console.ReadLine();
            }
        }
    }
}
