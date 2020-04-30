using System;

namespace _1.Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int countLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            int maxBonus = 0;
            int bestAttend = 0;

            for (int i = 0; i < countStudents; i++)
            {
                int attEachStudent = int.Parse(Console.ReadLine());

                double currentBonus = Math.Ceiling(((attEachStudent * 1.0 / countLectures * 1.0) * (5 + additionalBonus * 1.0)));
                int integerBonus = Convert.ToInt32(currentBonus);
                if (integerBonus >= maxBonus)
                {
                    maxBonus = integerBonus;
                    bestAttend = attEachStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {bestAttend} lectures.");
        }
    }
}
