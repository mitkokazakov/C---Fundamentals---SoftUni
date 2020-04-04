using System;

namespace _1._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandsArgs = command.Split(">>>");
                string mainCommand = commandsArgs[0];

                if (mainCommand == "Contains")
                {
                    string substr = commandsArgs[1];

                    if (input.Contains(substr))
                    {
                        Console.WriteLine($"{input} contains {substr}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (mainCommand == "Flip")
                {
                    string option = commandsArgs[1];
                    int startIndex = int.Parse(commandsArgs[2]);
                    int endIndex = int.Parse(commandsArgs[3]);

                    string substr = input.Substring(startIndex, endIndex - startIndex);

                    if (option == "Upper")
                    {
                        string changedSubstr = substr.ToUpper();
                        input = input.Replace(substr,changedSubstr);
                    }
                    else if (option == "Lower")
                    {
                        string changedSubstr = substr.ToLower();
                        input = input.Replace(substr, changedSubstr);
                    }

                    Console.WriteLine(input);
                }
                else if (mainCommand == "Slice")
                {
                    int startIndex = int.Parse(commandsArgs[1]);
                    int endIndex = int.Parse(commandsArgs[2]);

                    input = input.Remove(startIndex,endIndex - startIndex);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
