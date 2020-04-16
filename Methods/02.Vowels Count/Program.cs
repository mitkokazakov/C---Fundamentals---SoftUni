using System;

namespace _02.Vowels_Count
{
    class Program
    {
        static int VowelsCount(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool isVowel = input[i] == 'A'
                    || input[i] == 'E'
                    || input[i] == 'I'
                    || input[i] == 'O'
                    || input[i] == 'U'
                    || input[i] == 'a'
                    || input[i] == 'e'
                    || input[i] == 'i'
                    || input[i] == 'o'
                    || input[i] == 'u';
                    

                if (isVowel)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(VowelsCount(input));
        }
    }
}
