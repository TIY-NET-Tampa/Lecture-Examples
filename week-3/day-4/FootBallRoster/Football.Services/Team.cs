using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Services
{
    public class Team
    {
        public List<Player> Players { get; set; } = new List<Player>();

        public string Name { get; set; }
        
        public Player AddPlayer(string name, int num, double salary)
        {
            var player = new Player
            {
                Name = name,
                Number = num,
                Salary = salary
            };
            Players.Add(player);
            return player;
        }

        public void DeletePlayer(Guid selectedPlayer)
        {
            // Using a foreach Loop
            //var selected2 = new Player();
            //foreach (var player in Players)
            //{
            //    if (player.Id == selectedPlayer)
            //    {
            //        selected2 = player;
            //        break;
            //    }
            //}

            // using LINQ
            var selected = Players
                .FirstOrDefault(player => player.Id == selectedPlayer);
            if (selected != null)
            {
                Players.Remove(selected);
            }

        }

        public void UpdatePlayerStats(Guid selectedPlayer, int tackles, int interceptions, int touchdowns)
        {
            var player = Players.FirstOrDefault(f => f.Id == selectedPlayer);
            Players.Remove(player);
            player.Statistics.Tackles = tackles;
            player.Statistics.Interceptions = interceptions;
            player.Statistics.Touchdowns = touchdowns;
            Players.Add(player);
        }
    }
}
