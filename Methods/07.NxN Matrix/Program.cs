using System;

namespace _07.NxN_Matrix
{
    class Program
    {
        static void PrintMatrix(int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(count + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            PrintMatrix(N);

        }
    }
}
