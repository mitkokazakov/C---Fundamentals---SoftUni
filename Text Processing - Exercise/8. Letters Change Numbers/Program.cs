using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> alphabet = new Dictionary<string, int>();
            alphabet["a"] = 1;
            alphabet["b"] = 2;
            alphabet["c"] = 3;
            alphabet["d"] = 4;
            alphabet["e"] = 5;
            alphabet["f"] = 6;
            alphabet["g"] = 7;
            alphabet["h"] = 8;
            alphabet["i"] = 9;
            alphabet["j"] = 10;
            alphabet["k"] = 11;
            alphabet["l"] = 12;
            alphabet["m"] = 13;
            alphabet["n"] = 14;
            alphabet["o"] = 15;
            alphabet["p"] = 16;
            alphabet["q"] = 17;
            alphabet["r"] = 18;
            alphabet["s"] = 19;
            alphabet["t"] = 20;
            alphabet["u"] = 21;
            alphabet["v"] = 22;
            alphabet["w"] = 23;
            alphabet["x"] = 24;
            alphabet["y"] = 25;
            alphabet["z"] = 26;
            
            
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal totalNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentString = arr[i];

                string firstLetter = currentString[0].ToString();
                string numberAsString = String.Empty;
                int number = 0;
                string lastLetter = currentString[currentString.Length - 1].ToString();

                for (int j = 1; j < currentString.Length; j++)
                {
                    if (Char.IsDigit(currentString[j]))
                    {
                        numberAsString += currentString[j];
                    }
                }

                number = int.Parse(numberAsString);

                int positionOfFirstLetter = 0;

                if (alphabet.ContainsKey(firstLetter.ToLower()))
                {
                    positionOfFirstLetter = alphabet[firstLetter.ToLower()];
                }

                int positionOflastLetter = 0;

                if (alphabet.ContainsKey(lastLetter.ToLower()))
                {
                    positionOflastLetter = alphabet[lastLetter.ToLower()];
                }

                char FL = Convert.ToChar(firstLetter);
                char LL = Convert.ToChar(lastLetter);

                decimal resultNumber = 0;
                

                if (FL >= 65 && FL <= 90)
                {
                    resultNumber = number * 1.0m / positionOfFirstLetter * 1.0m;
                    //Console.WriteLine("upper");
                }
                else if (FL >= 97 &&  FL<= 122 )
                {
                    resultNumber = (number * 1.0m) * positionOfFirstLetter * 1.0m;
                    //Console.WriteLine("lower");
                }

                if (LL >= 65 && LL <= 90)
                {
                    resultNumber = resultNumber - positionOflastLetter * 1.0m;
                    //Console.WriteLine("upper");
                }
                else if (LL >= 97 && LL <= 122)
                {
                    resultNumber = resultNumber + positionOflastLetter * 1.0m;
                    //Console.WriteLine("lower");
                }
                totalNumber += resultNumber;
            }

            Console.WriteLine($"{totalNumber:f2}");
        }
    }
}
