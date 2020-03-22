using System;
using System.Collections.Generic;
using System.Text;

namespace _5._Teamwork_projects
{
    class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public Team(string user, string teamName)
        {
            this.Creator = user;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }

        

    }


}
