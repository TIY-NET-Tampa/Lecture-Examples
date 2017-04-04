using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public City()
        {

        }

        public City(SqlDataReader reader)
        {
            Name = reader["Name"].ToString();
            Id = (int)reader["Id"];
            Country = reader["Country"].ToString();
            Population = (int)reader["Population"];
            State = reader["State"].ToString();
        }
    }
}
