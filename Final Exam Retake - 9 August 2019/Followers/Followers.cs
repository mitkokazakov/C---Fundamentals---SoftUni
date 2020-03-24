using System;
using System.Collections.Generic;
using System.Text;

namespace Followers
{
    class Followers
    {
        public string Username { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public int Sum => this.Likes + this.Comments;

        public Followers(string username)
        {
            this.Username = username;
            this.Likes = 0;
            this.Comments = 0;
        }
        public void IncreaseLikes(string username, int count)
        {
            this.Username = username;
            this.Likes += count;
            //this.Comments = 0;
        }
        public void IncreasaeComments(string username)
        {
            this.Username = username;
            this.Comments += 1;
        }
    }
}
