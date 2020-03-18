using System;

namespace _2.Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weapons = Console.ReadLine().Split("|");

            string commands = Console.ReadLine();

            while (commands != "Done")
            {
                string[] commandArgs = commands.Split();
                string mainCommand = commandArgs[0];

                if (mainCommand == "Move")
                {
                    string direction = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);

                    if (direction == "Left")
                    {
                        MoveLeft(weapons, index);
                    }
                    else if (direction == "Right")
                    {
                        MoveRight(weapons, index);
                    }

                }
                else if (mainCommand == "Check")
                {
                    string OddEven = commandArgs[1];

                    if (OddEven == "Even")
                    {
                        PrintEvenElements(weapons);
                    }
                    else if (OddEven == "Odd")
                    {
                        PrintOddElements(weapons);
                    }
                }

                commands = Console.ReadLine();
            }

            PrintCraftedWeapon(weapons);
        }

        private static void PrintCraftedWeapon(string[] weapons)
        {
            Console.Write("You crafted ");
            Console.Write(String.Join("", weapons));
            Console.WriteLine("!");
        }

        private static void PrintOddElements(string[] weapons)
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(weapons[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void PrintEvenElements(string[] weapons)
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(weapons[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void MoveRight(string[] weapons, int index)
        {
            if (index >= 0 && index < weapons.Length - 1)
            {
                string weaponToMove = weapons[index];
                string rightWeapon = weapons[index + 1];

                weapons[index + 1] = weaponToMove;
                weapons[index] = rightWeapon;
            }
        }

        private static void MoveLeft(string[] weapons, int index)
        {
            if (index > 0 && index <= weapons.Length - 1)
            {
                string weaponToMove = weapons[index];
                string leftWeapon = weapons[index - 1];

                weapons[index - 1] = weaponToMove;
                weapons[index] = leftWeapon;
            }
        }
    }
}
