using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> listTeams = new List<Team>();
            int countOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] registerTeams = Console.ReadLine().Split("-");
                string creator = registerTeams[0];
                string teamName = registerTeams[1];

                Team team = new Team(creator,teamName);

                //bool existingTeamName = listTeams.Find(x => x.TeamName == teamName);
                if (listTeams.Find(x => x.TeamName == teamName) != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (listTeams.Find(x => x.Creator == creator) != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                listTeams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string joinUsers = Console.ReadLine();

            while (joinUsers != "end of assignment")
            {
                string[] usersArg = joinUsers.Split("->");
                string member = usersArg[0];
                string teamName = usersArg[1];

                Team existingTeamName = listTeams.Find(x => x.TeamName == teamName);
                Team existingMember = listTeams.Find(x => x.Members.Contains(member) || x.Creator == member);

                if (existingTeamName == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    joinUsers = Console.ReadLine();
                    continue;
                }
                if (existingMember != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    joinUsers = Console.ReadLine();
                    continue;
                }

                existingTeamName.Members.Add(member);

                joinUsers = Console.ReadLine();
            }

            List<Team> teamToDisband = listTeams.Where(x => x.Members.Count == 0).OrderBy(x => x.TeamName).ToList();
            listTeams = listTeams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).ToList();

            foreach (Team team in listTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Team to disband:");

            foreach (var teams in teamToDisband)
            {
                Console.WriteLine(teams.TeamName);
            }
            
        }
    }
}
