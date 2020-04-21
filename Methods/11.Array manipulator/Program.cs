using System;
using System.Linq;
using System.Collections.Generic;
namespace Array_Manipulator
{
    class Program
    {
        static int[] Exchange(int[] Array, int index, int len)
        {
            int[] exchangedArr = new int[len];
            int[] leftSideArr = new int[index + 1];

            if (index > len - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
                exchangedArr = Array;
                return exchangedArr;
            }
            else
            {
                for (int i = 0; i <= index; i++)
                {
                    leftSideArr[i] = Array[i];
                }
                for (int i = index + 1; i < len; i++)
                {
                    exchangedArr[i - index - 1] = Array[i];
                }
                for (int j = 0; j < index + 1; j++)
                {
                    exchangedArr[j + len - index - 1] = leftSideArr[j];
                }
                return exchangedArr;
            }

        }

        static void MaxOddEven(int[] Array, string input)
        {
            int maxOdd = int.MinValue;
            int maxIndex = 0;
            if (input == "max odd")
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] % 2 != 0 && Array[i] >= maxOdd)
                    {
                        maxOdd = Array[i];
                        maxIndex = i;
                    }
                }
                if (maxOdd != int.MinValue)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }


            }
            else if (input == "max even")
            {
                int maxEven = int.MinValue;

                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] % 2 == 0 && Array[i] >= maxEven)
                    {
                        maxEven = Array[i];
                        maxIndex = i;
                    }
                }
                if (maxEven != int.MinValue)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }

            }
        }

        static void MinOddEven(int[] Array, string input)
        {
            int minOdd = int.MaxValue;
            int minIndex = 0;
            if (input == "min odd")
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] % 2 != 0 && Array[i] <= minOdd)
                    {
                        minOdd = Array[i];
                        minIndex = i;
                    }
                }
                if (minOdd == int.MaxValue)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minIndex);
                }
            }

            else if (input == "min even")
            {
                int minEven = int.MaxValue;

                for (int j = 0; j < Array.Length; j++)
                {
                    if (Array[j] % 2 == 0 && Array[j] <= minEven)
                    {
                        minEven = Array[j];
                        minIndex = j;
                    }
                }
                if (minEven == int.MaxValue)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minIndex);
                }
            }
        }

        static void FirstOddEven(int[] Array, int count, string value)
        {
            int counter = 0;
            int[] firstArr = new int[count];
            List<int> resultList = new List<int>();
            if (count > Array.Length || count < 1)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (value == "first odd")
                {


                    for (int i = 0; i < Array.Length; i++)
                    {
                        if (counter == count)
                        {
                            break;
                        }
                        if (Array[i] % 2 != 0)
                        {
                            firstArr[counter] = Array[i];
                            counter++;
                        }
                    }
                }
                else if (value == "first even")
                {
                    for (int i = 0; i < Array.Length; i++)
                    {
                        if (counter == count)
                        {
                            break;
                        }
                        if (Array[i] % 2 == 0)
                        {
                            firstArr[counter] = Array[i];
                            counter++;
                        }
                    }
                }
                //var result = string.Join(",", firstArr);
                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.Write("[");
                    for (int t = 0; t < firstArr.Length; t++)
                    {
                        if (firstArr[t] != 0)
                        {
                            resultList.Add(firstArr[t]);
                        }
                    }
                    
                    
                        Console.Write(String.Join(", ", resultList));
                    
                    //Console.Write(result);
                    Console.WriteLine("]");
                }

            }

        }

        static void LastOddEven(int[] MyArray, int count, string value)
        {
            int counter = 0;
            int[] lastArr = new int[count];
            List<int> resultList = new List<int>();

            if (count > MyArray.Length || count < 1)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (value == "last odd")
                {
                    for (int i = MyArray.Length - 1; i >= 0; i--)
                    {
                        if (counter == count)
                        {
                            break;
                        }
                        if (MyArray[i] % 2 != 0)
                        {
                            lastArr[counter] = MyArray[i];
                            counter++;
                        }
                    }
                }
                else if (value == "last even")
                {
                    for (int i = MyArray.Length - 1; i >= 0; i--)
                    {
                        if (counter == count)
                        {
                            break;
                        }
                        if (MyArray[i] % 2 == 0)
                        {
                            lastArr[counter] = MyArray[i];
                            counter++;
                        }
                    }
                }

                Array.Reverse(lastArr);
                //var result = String.Join(",", lastArr);


                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.Write("[");
                    for (int t = 0; t < lastArr.Length; t++)
                    {
                        if (lastArr[t] != 0)
                        {
                            resultList.Add(lastArr[t]);
                        }
                    }
                    Console.Write(String.Join(", ",resultList));
                    //Console.Write(result);
                    Console.WriteLine("]");
                }
            }

        }

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int len = numbers.Length;

            string input = Console.ReadLine();

            //string[] exchangeIndex = input.Split();
            //int desiredIndex = int.Parse(exchangeIndex[1]);
            //string compareInput = firstLast[0];
            int[] finalArr = new int[len];
            finalArr = numbers;
            //finalArr = Exchange(numbers, desiredIndex, len);

            while (input != "end")
            {
                string[] firstLast = input.Split();
                string compareInput = firstLast[0];
                string firstLastValue = string.Empty;
                int valueOfCount = 0;

                if (compareInput == "exchange")
                {
                    string[] exchangeIndex = input.Split();
                    int desiredIndex = int.Parse(exchangeIndex[1]);
                    finalArr = Exchange(finalArr, desiredIndex, len);
                }
                else if (compareInput == "min")
                {

                    MinOddEven(finalArr, input);
                }
                else if (compareInput == "max")
                {

                    MaxOddEven(finalArr, input);
                }
                else if (compareInput == "first")
                {

                    firstLastValue = firstLast[0] + " " + firstLast[2];
                    valueOfCount = int.Parse(firstLast[1]);
                    FirstOddEven(finalArr, valueOfCount, firstLastValue);

                }
                else if (compareInput == "last")
                {

                    firstLastValue = firstLast[0] + " " + firstLast[2];
                    valueOfCount = int.Parse(firstLast[1]);
                    LastOddEven(finalArr, valueOfCount, firstLastValue);

                }
                input = Console.ReadLine();
            }

            Console.Write("[");
            string finalResult = String.Join(", ", finalArr);
            Console.Write(finalResult);
            Console.WriteLine("]");
            
        }
    }
}
