using System;

namespace _10.TopNum
{
    class Program
    {
        static void PrintNUmbers(int number)
        {
            for (int i = 17; i <= number; i++)
            {
                int assumDigits = i;
                int sum = 0;
                while (assumDigits != 0)
                {
                    int digit = assumDigits % 10;
                    sum += digit;
                    assumDigits = assumDigits / 10;
                }


                int currentNum = i;

                if (sum % 8 == 0)
                {
                    while (currentNum != 0)
                    {
                        int secondDigit = currentNum % 10;
                        currentNum = currentNum / 10;

                        if (secondDigit % 2 != 0)
                        {
                            
                            Console.WriteLine(i);
                            break;
                        }
                    }
                    sum = 0;
                }
                
                
            }
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintNUmbers(input);

        }
    }
}
