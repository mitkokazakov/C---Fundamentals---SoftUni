using System;

namespace _3._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] text = Console.ReadLine().Split("\\");

            string lastString = text[text.Length - 1];

            string[] fileInfo = lastString.Split(".");

            Console.WriteLine($"File name: {fileInfo[0]}");
            Console.WriteLine($"File extension: {fileInfo[1]}");
            
        }
    }
}
