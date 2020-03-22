using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Articles_2._0
{
    class Arts
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Arts(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
