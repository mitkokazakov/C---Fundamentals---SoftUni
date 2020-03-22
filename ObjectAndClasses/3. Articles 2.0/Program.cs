using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfArticles = int.Parse(Console.ReadLine());
            List<Arts> listOfArts = new List<Arts>();

            for (int i = 0; i < numOfArticles; i++)
            {
                string[] articlesArr = Console.ReadLine().Split(", ");
                string title = articlesArr[0];
                string content = articlesArr[1];
                string author = articlesArr[2];

                Arts arts = new Arts(title, content, author);

                listOfArts.Add(arts);
            }

            string filter = Console.ReadLine();

            if (filter == "title")
            {
                listOfArts = listOfArts.OrderBy(x => x.Title).ToList();
            }
            else if (filter == "content")
            {
                listOfArts = listOfArts.OrderBy(x => x.Content).ToList();
            }
            else if (filter == "author")
            {
                listOfArts = listOfArts.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(String.Join(Environment.NewLine, listOfArts));

        }
    }
}
