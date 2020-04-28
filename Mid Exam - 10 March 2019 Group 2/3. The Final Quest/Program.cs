using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            string commands = Console.ReadLine();

            while (commands != "Stop")
            {
                string[] commandsArg = commands.Split();
                string mainCommand = commandsArg[0];

                if (mainCommand == "Delete")
                {
                    DeletePreviousWord(words, commandsArg);
                }
                else if (mainCommand == "Swap")
                {
                    string word1 = commandsArg[1];
                    string word2 = commandsArg[2];

                    SwapWords(words, word1, word2);
                }
                else if (mainCommand == "Put")
                {
                    string word = commandsArg[1];
                    int index = int.Parse(commandsArg[2]);

                    PutWordOnPreviousPosition(words, word, index);
                }
                else if (mainCommand == "Sort")
                {
                    words = words.OrderByDescending(x => x).ToList();
                }
                else if (mainCommand == "Replace")
                {
                    string word1 = commandsArg[1];
                    string word2 = commandsArg[2];

                    ReplaceWords(words, word1, word2);
                }


                commands = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", words));
        }

        private static void ReplaceWords(List<string> words, string word1, string word2)
        {
            if (words.Contains(word2))
            {
                int indexOfWord2 = words.IndexOf(word2);
                words[indexOfWord2] = word1;
            }
        }

        private static void PutWordOnPreviousPosition(List<string> words, string word, int index)
        {
            if (index > 0 && index <= words.Count +1)
            {
                words.Insert(index - 1, word);
            }
            
        }

        private static void SwapWords(List<string> words, string word1, string word2)
        {
            if (words.Contains(word1) && words.Contains(word2))
            {
                int index1 = words.IndexOf(word1);
                int index2 = words.IndexOf(word2);

                words[index1] = word2;
                words[index2] = word1;
            }
        }

        private static void DeletePreviousWord(List<string> words, string[] commandsArg)
        {
            int index = int.Parse(commandsArg[1]);
            if (index >= 0 && index < words.Count - 1)
            {
                words.RemoveAt(index + 1);
            }
        }
    }
}
