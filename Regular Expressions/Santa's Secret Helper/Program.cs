using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> goodChildren = new List<string>();

            string input = Console.ReadLine();
            string pattern = @"@([A-Za-z]+)[^@:\->!]*?!([G,N]+)!";

            //string decryptedMessage = String.Empty;
            
            while (input != "end")
            {
                StringBuilder decryptedMessage = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    decryptedMessage.Append (Convert.ToChar(input[i] - key));
                }

                Regex regex = new Regex(pattern);
                var matches = regex.Matches(decryptedMessage.ToString());

                foreach  (Match kid in matches)
                {
                    if (kid.Groups[2].Value == "G")
                    {
                        goodChildren.Add(kid.Groups[1].Value);
                    }
                }

                //Console.WriteLine(decryptedMessage);
                input = Console.ReadLine();
                
            }

            foreach (var kid in goodChildren)
            {
                Console.WriteLine(kid);
            }
        }
    }
}
