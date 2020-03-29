using System;
using System.Linq;
namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int seqLen = int.Parse(Console.ReadLine());
            string input = "";
            int[] Sequences = new int[seqLen];
            int[] finalArr = new int[seqLen];
            int bestSeq = 0;
            int currentIndex = 0;
            int counterBestSeq = 0;
            int currentSample = 0;
            int minIndex = int.MaxValue;
            int sum = 0;
            int bestSum = 0;


            while (true)
            {
                input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }


                Sequences = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                //Console.WriteLine(String.Join(" ", Sequences));
                int currentSequence = 0;
                int maxSequence = 0;
                int lastIndex = 0;


                for (int i = 0; i < Sequences.Length; i++)
                {
                    if (Sequences[i] == 1)
                    {
                        currentSequence++;
                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;
                            lastIndex = i;

                        }
                    }
                    else
                    {

                        currentSequence = 0;
                    }


                }

                currentIndex = lastIndex - currentSequence + 1;
                sum = Sequences.Sum();
                bool thisIsBestChoise = false;


                if (maxSequence > bestSeq)
                {
                    thisIsBestChoise = true;
                }
                else if (maxSequence == bestSeq)
                {
                    if (currentIndex < minIndex)
                    {
                        thisIsBestChoise = true;
                    }
                    else if (currentIndex == minIndex)
                    {
                        if (sum >= bestSum)
                        {
                            thisIsBestChoise = true;
                        }
                    }
                }
                counterBestSeq++;

                if (thisIsBestChoise)
                {
                    finalArr = Sequences;
                    bestSeq = maxSequence;
                    minIndex = currentIndex;
                    bestSum = sum;
                    currentSample = counterBestSeq;
                }
            }

            Console.WriteLine($"Best DNA sample {currentSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", finalArr));
            //Console.WriteLine(maxSequence + " " + bestSum);
            //Console.WriteLine(minIndex);

        }
    }
}

