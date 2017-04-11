using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PlayerRoster.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public string Position { get; set; }
        public int? SkillLevel { get; set; }

        public Player() { }
        public Player(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.Name = reader["FullName"]?.ToString();
            this.Number = reader["PreferedJerseyNumber"] as int?;
            this.Position = reader["PreferedPosition"]?.ToString();
            this.SkillLevel = reader["SkillLevel"] as int?;
        }
    }
}