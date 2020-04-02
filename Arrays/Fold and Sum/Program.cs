using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenInputArr = inputArr.Length;
            int lenOfRevArr = lenInputArr / 4;
            int[] firstReversedArray = new int[lenOfRevArr];
            int[] secondReversedArray = new int[lenOfRevArr];
            int[] restArray = new int[lenOfRevArr*2];
            int[] fullReversedArray = new int[lenOfRevArr * 2];
            

            for (int i = 0; i < lenOfRevArr; i++)
            {
                firstReversedArray[i] = inputArr[i];
            }
            for (int j = inputArr.Length-1; j >= inputArr.Length - lenOfRevArr ; j--)
            {
                secondReversedArray[Math.Abs(inputArr.Length-1-j)] = inputArr[j];
            }
            for (int m = lenOfRevArr; m <= inputArr.Length - 1 - lenOfRevArr; m++)
            {
                restArray[Math.Abs(m - lenOfRevArr)] = inputArr[m];
            }

            Array.Reverse(firstReversedArray);

            for (int k = 0; k < firstReversedArray.Length; k++)
            {
                fullReversedArray[k] = firstReversedArray[k];
            }
            for (int h = 0; h < secondReversedArray.Length; h++)
            {
                fullReversedArray[h + lenOfRevArr] = secondReversedArray[h];
            }

            int[] sumArray = new int[restArray.Length];

            for (int g = 0; g < restArray.Length; g++)
            {
                sumArray[g] = fullReversedArray[g] + restArray[g];
            }

            foreach (var digits in sumArray)
            {
                Console.Write(digits + " ");
            }
            Console.WriteLine();
            

        }
    }
}
