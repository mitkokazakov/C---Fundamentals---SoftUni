using System;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            PrintTitle(title);
            PrintContent(content);

            string comments = Console.ReadLine();

            while (comments != "end of comments")
            {
                PrintComments(comments);

                comments = Console.ReadLine();
            }
        }

        public static void PrintTitle(string title)
        {
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
        }

        public static void PrintContent(string content)
        {
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
        }

        public static void PrintComments(string comments)
        {
            Console.WriteLine("<div>");
            Console.WriteLine($"    {comments}");
            Console.WriteLine("</div>");
        }
    }
}
