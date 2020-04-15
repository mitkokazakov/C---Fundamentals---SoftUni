using System;

namespace _01._Smallest_of_Three_Nums
{
    class Program
    {
        static void SmallestNum()
        {
            int number = 0;
            int smallestNum = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number < smallestNum)
                {
                    smallestNum = number;
                }
            }

            Console.WriteLine(smallestNum);
        }

        static void Main(string[] args)
        {
            SmallestNum();

            
        }

        
    }
}
