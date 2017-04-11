using PlayerRoster.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PlayerRoster.Services
{
    public class PlayerServices
    {
        const string connectionString = @"Server=localhost\SQLEXPRESS;Database=LegaueDatabase;Trusted_Connection=True;";
        public List<Player> GetAllPlayers()
        {
            var rv = new List<Player>();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Players";
                var cmd = new SqlCommand(query, connection);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rv.Add(new Player(reader));
                }
                connection.Close();
            }
            return rv;
        }
    }
}