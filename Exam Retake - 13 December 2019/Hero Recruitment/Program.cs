using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();
            List<Heroes> listOfHeroes = new List<Heroes>();

            while (commands != "End")
            {
                string[] commandsArg = commands.Split();
                string mainCommand = commandsArg[0];
                string name = commandsArg[1];
                Heroes existHeroe = listOfHeroes.Find(x => x.Name == name);
                Heroes heroes = new Heroes(name);

                if (mainCommand == "Enroll")
                {
                    if (existHeroe != null)
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }
                    else
                    {
                        listOfHeroes.Add(heroes);
                    }
                    

                }
                else if (mainCommand == "Learn")
                {
                    string spell = commandsArg[2];
                    Heroes existSpellName = listOfHeroes.Find(x => x.spellbook.Contains(spell));

                    if (existHeroe == null)
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else if(existSpellName != null)
                    {
                        Console.WriteLine($"{name} has already learnt {spell}.");
                    }
                    else
                    {
                        existHeroe.AddSpellName(spell);
                    }
                }
                else if (mainCommand == "Unlearn")
                {
                    string spell = commandsArg[2];
                    Heroes existSpellName = listOfHeroes.Find(x => x.spellbook.Contains(spell));

                    if (existHeroe == null)
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else if (existSpellName == null)
                    {
                        Console.WriteLine($"{name} doesn't know {spell}.");
                    }
                    else
                    {
                        existHeroe.RemoveSpellName(spell);
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in listOfHeroes.OrderByDescending(x => x.spellbook.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"== {hero.Name}: {String.Join(", ",hero.spellbook)}");
            }
        }
    }
}
