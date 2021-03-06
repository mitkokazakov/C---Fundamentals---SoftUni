﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"[\s]([A-Za-z0-9]+[.\-_A-Za-z]+@[A-Za-z]+[A-Za-z-.]+\.[A-Za-z]+)";

            Regex regex = new Regex(pattern);

            var extractedEmails = regex.Matches(text);

            foreach (Match mail in extractedEmails)
            {
                Console.WriteLine(mail.Groups[1].Value);
            }
        }
    }
}
