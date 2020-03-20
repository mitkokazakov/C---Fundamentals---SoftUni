using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"[$]{6,}|[@]{6,}|[#]{6,}|[\^]{6,}";
            string allSymbolsLeft = String.Empty;
            string allSymboRight = String.Empty;
            string singleSymbolLeft = String.Empty;
            string singleSymbolRight = String.Empty;
            string leftSide = String.Empty;
            string rightSide = String.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                string currentTicket = input[i];
                
                if (currentTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (currentTicket.Length == 20)
                {
                    leftSide = currentTicket.Substring(0,10);
                    rightSide = currentTicket.Substring(10,10);

                    Regex regex = new Regex(pattern);
                    var matchesLeftSide = regex.Match(leftSide);
                    var matchesRightSide = regex.Match(rightSide);

                    int lenLeftSide = matchesLeftSide.Length;
                    int lenRightSide = matchesRightSide.Length;

                    allSymbolsLeft = matchesLeftSide.ToString();
                    allSymboRight = matchesRightSide.ToString();

                    if (lenLeftSide >= 6 && lenRightSide >= 6)
                    {
                        singleSymbolLeft = allSymbolsLeft[0].ToString();
                        singleSymbolRight = allSymboRight[0].ToString();
                    }
                    

                    if (lenLeftSide >= 6 && lenRightSide >= 6 &&  singleSymbolLeft == singleSymbolRight  )
                    {
                        int bestLen = Math.Min(lenLeftSide,lenRightSide);

                        if (lenRightSide == 10 && lenLeftSide == 10)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - {lenRightSide}{singleSymbolRight} Jackpot!");
                        }
                        else if (bestLen >=6 && bestLen <= 9)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - {bestLen}{singleSymbolRight}");
                        }
                        
                        
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }
                
            }

            //Console.WriteLine(leftSide);
            //Console.WriteLine(rightSide);
        }
    }
}
