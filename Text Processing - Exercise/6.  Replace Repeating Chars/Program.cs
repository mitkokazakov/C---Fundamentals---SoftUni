using System;
using System.Collections.Generic;

namespace _6.__Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = String.Empty;
            result = text[0].ToString();

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i-1])
                {
                    continue;
                }
                else
                {
                    result += text[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
