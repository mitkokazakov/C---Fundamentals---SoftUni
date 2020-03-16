using System;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string text = Console.ReadLine();

                int startIndexOfName = text.IndexOf('@');
                int endIndexOfName = text.IndexOf('|');
                int startIndexOfAges = text.IndexOf('#');
                int endIndexOfAges = text.IndexOf('*');

                string name = text.Substring(startIndexOfName+1, endIndexOfName-startIndexOfName-1);
                string age = text.Substring(startIndexOfAges + 1, endIndexOfAges - startIndexOfAges - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
