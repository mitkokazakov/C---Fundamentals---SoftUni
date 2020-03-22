using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialArticle = Console.ReadLine().Split(", ");
            string title = initialArticle[0];
            string content = initialArticle[1];
            string author = initialArticle[2];

            Articles article = new Articles(title, content, author);

            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] currentCommand = Console.ReadLine().Split(": ");
                string command = currentCommand[0];
                string value = currentCommand[1];

                if (command == "Edit")
                {
                    article.Edit(value);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(value);
                }
                else if (command == "Rename")
                {
                    article.Rename(value);
                }
            }

            Console.WriteLine(article);

        }
    }
}
