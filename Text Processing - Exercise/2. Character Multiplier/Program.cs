using System;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];
            int len = 0;
            int finalResult = 0;
            int sumOfRestLetters = 0;
            string rest = String.Empty;

            if (firstWord.Length < secondWord.Length)
            {
                sumOfRestLetters = SumRemaingLettersIfSecondWordIsBigger(firstWord, secondWord, out len, sumOfRestLetters, out rest);
            }
            else if (firstWord.Length > secondWord.Length)
            {
                sumOfRestLetters = SumRemainingLettersIfFirstWordIsBigger(firstWord, secondWord, out len, sumOfRestLetters, out rest);
            }
            else
            {
                len = secondWord.Length;
            }

            for (int i = 0; i < len; i++)
            {
                finalResult += firstWord[i] * secondWord[i];
            }

            Console.WriteLine(finalResult + sumOfRestLetters);

            
        }

        private static int SumRemainingLettersIfFirstWordIsBigger(string firstWord, string secondWord, out int len, int sumOfRestLetters, out string rest)
        {
            len = secondWord.Length;
            rest = firstWord.Substring(len, firstWord.Length - secondWord.Length);
            for (int i = 0; i < rest.Length; i++)
            {
                sumOfRestLetters += rest[i];
            }

            return sumOfRestLetters;
        }

        private static int SumRemaingLettersIfSecondWordIsBigger(string firstWord, string secondWord, out int len, int sumOfRestLetters, out string rest)
        {
            len = firstWord.Length;
            rest = secondWord.Substring(len, secondWord.Length - firstWord.Length);
            for (int i = 0; i < rest.Length; i++)
            {
                sumOfRestLetters += rest[i];
            }

            return sumOfRestLetters;
        }
    }
}
