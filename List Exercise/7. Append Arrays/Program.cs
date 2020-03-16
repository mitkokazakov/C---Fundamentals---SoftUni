using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> newList = new List<string>();
            List<string> finalResult = new List<string>();

            for (int i = numbers.Count-1; i >= 0; i--)
            {
                newList = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var element in newList)
                {
                    finalResult.Add(element);
                }
            }

            Console.WriteLine(String.Join(" ",finalResult));
            

            
            


            
        }
    }
}
