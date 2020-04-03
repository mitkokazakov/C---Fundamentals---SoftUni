using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
