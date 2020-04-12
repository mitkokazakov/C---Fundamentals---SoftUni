using System;
using System.Collections.Generic;
using System.Text;

namespace Judge
{
    class Scores
    {
        public Dictionary<string, int> results { get; set; }

        public Scores(string student, int points)
        {
            this.results[student] = points;
        }
    }
}
