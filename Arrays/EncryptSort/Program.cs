using System;

namespace EncryptSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLInes = int.Parse(Console.ReadLine());

            int sumVowels = 0;
            double sumConsonant = 0;
            double finalSum = 0;
            double[] sortedArray = new double[numOfLInes];

            for (int i = 0; i < numOfLInes; i++)
            {
                string name = Console.ReadLine();

                for (int j = 0; j < name.Length; j++)
                {
                    bool vowel = name[j] == 'a'
                        || name[j] == 'e' 
                        || name[j] == 'i'  
                        || name[j] == 'o' 
                        || name[j] == 'u'
                        || name[j] == 'A'
                        || name[j] == 'E'
                        || name[j] == 'I'
                        || name[j] == 'O'
                        || name[j] == 'U';

                    if (vowel)
                    {
                        sumVowels += name[j] * name.Length;
                    }
                    else
                    {
                        sumConsonant += name[j] / name.Length;
                    }
                }

                finalSum = sumVowels + sumConsonant;
                //Console.WriteLine(finalSum);
                sortedArray[i] = finalSum;

                sumVowels = 0;
                sumConsonant = 0;
                finalSum = 0;
            }

            Array.Sort(sortedArray);

            foreach (var value in sortedArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}
