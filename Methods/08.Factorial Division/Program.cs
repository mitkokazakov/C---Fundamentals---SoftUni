using System;

namespace _08.Factorial_Division
{
    class Program
    {
        static double FirstFactoriel(double firstNum)
        {
            double factoriel = 1;

            for (int i = 1; i <= firstNum ; i++)
            {
                factoriel *= i;
            }

            return factoriel;
        }

        static double SecondFactoriel(double secondNum)
        {
            double factoriel = 1;

            for (int i = 1; i <= secondNum; i++)
            {
                factoriel *= i;
            }

            return factoriel;
        }


        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double firstFactoriel = FirstFactoriel(firstNum);
            double secondFactoriel = SecondFactoriel(secondNum);

            
                Console.WriteLine($"{firstFactoriel / secondFactoriel:f2}");
            
            

        }
    }
}
