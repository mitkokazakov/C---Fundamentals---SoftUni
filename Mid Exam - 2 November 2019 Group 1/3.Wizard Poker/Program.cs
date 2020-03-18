using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            List<string> newDeck = new List<string>();

            string commands = Console.ReadLine();

            while (commands != "Ready")
            {
                string[] commandArgs = commands.Split();
                string mainCommand = commandArgs[0];

                if (mainCommand == "Add")
                {
                    AddCardToTheEnd(cards, newDeck, commandArgs);
                }
                else if (mainCommand == "Insert")
                {
                    InsertCardAtGivenIndex(cards, newDeck, commandArgs);
                }
                else if (mainCommand == "Remove")
                {
                    RemoveCard(newDeck, commandArgs);

                }
                else if (mainCommand == "Swap")
                {
                    SwapTwoCards(newDeck, commandArgs);
                }
                else if (mainCommand == "Shuffle")
                {
                    ReverseTheDeck(newDeck);
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", newDeck));
        }

        private static void ReverseTheDeck(List<string> newDeck)
        {
            newDeck.Reverse();
        }

        private static void SwapTwoCards(List<string> newDeck, string[] commandArgs)
        {
            string card1 = commandArgs[1];
            string card2 = commandArgs[2];

            int index1 = newDeck.IndexOf(card1);
            int index2 = newDeck.IndexOf(card2);

            newDeck[index1] = card2;
            newDeck[index2] = card1;
        }

        private static void RemoveCard(List<string> newDeck, string[] commandArgs)
        {
            string cardName = commandArgs[1];

            if (newDeck.Contains(cardName))
            {
                newDeck.Remove(cardName);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }

        private static void InsertCardAtGivenIndex(List<string> cards, List<string> newDeck, string[] commandArgs)
        {
            string cardName = commandArgs[1];
            int index = int.Parse(commandArgs[2]);

            if (!(index >= 0 && index < cards.Count) || !cards.Contains(cardName))
            {
                Console.WriteLine("Error!");
            }
            else
            {
                newDeck.Insert(index, cardName);
            }
        }

        private static void AddCardToTheEnd(List<string> cards, List<string> newDeck, string[] commandArgs)
        {
            string cardName = commandArgs[1];

            if (cards.Contains(cardName))
            {
                newDeck.Add(cardName);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
    }
}
