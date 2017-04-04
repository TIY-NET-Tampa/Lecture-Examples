using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public List<City> GetAllCities(SqlConnection connection)
        {
            var cities = new List<City>();
            // Basic Select
            /*
             SELECT * FROM City

             */
            // estblish the QUERY
            var sqlCommand = new SqlCommand(@"SELECT * 
                                                FROM City", connection);
            // open the connection
            connection.Open();
            // Run Query
            var reader = sqlCommand.ExecuteReader();
            // Read Results
            while (reader.Read())
            {
                var city = new City(reader);
                cities.Add(city);
            }
            // Close Connection
            connection.Close();
            return cities;
        }

        static public void AddCity(SqlConnection connection, City CityToAdd)
        {
            var text = @"INSERT INTO City (Name, State, Population)" +
                        "Values (@City, @State, @Population)";

            var cmd = new SqlCommand(text, connection);

            cmd.Parameters.AddWithValue("@City", CityToAdd.Name);
            cmd.Parameters.AddWithValue("@State", CityToAdd.State);
            cmd.Parameters.AddWithValue("@Population", CityToAdd.Population);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        static public void UpdateCity(SqlConnection connection, City cityToUpdate)
        {
            var cmdText = @"UPDATE City " +
                           "SET Name=@City, State=@State, Population=@Population " +
                           "WHERE Id=@Id";

            var cmd = new SqlCommand(cmdText, connection);

            cmd.Parameters.AddWithValue("@City", cityToUpdate.Name);
            cmd.Parameters.AddWithValue("@State", cityToUpdate.State);
            cmd.Parameters.AddWithValue("@Population", cityToUpdate.Population);
            cmd.Parameters.AddWithValue("@Id", cityToUpdate.Id);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        static void DeleteCity (SqlConnection connection, int cityId)
        {
            var cmdText = @"DELETE " +
                                    "FROM City " +
                                    "WHERE Id=@Id"; ;

            var cmd = new SqlCommand(cmdText, connection);

            cmd.Parameters.AddWithValue("@Id", cityId);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        static void Main(string[] args)
        {
            // WHere is the Database
            const string connectionString =
                @"Server=localhost\SQLEXPRESS;Database=Cities;Trusted_Connection=True;";
            // Open with using something

            var cities = new List<City>();
            using (var connection = new SqlConnection(connectionString))
            {
                cities = GetAllCities(connection);
                Console.WriteLine("Before");
                foreach (var city in cities)
                {
                    Console.WriteLine(city.Name);
                }

                AddCity(connection, new City { Name = "Denver", State = "Colorado", Population = 250000 });
                UpdateCity(connection, new City { Id = 6, Name = "Colorado Sptrings", State = "Co", Population = 1000 });
                cities = GetAllCities(connection);
                Console.WriteLine("After");
                foreach (var city in cities)
                {
                    Console.WriteLine(city.Name);
                }
                DeleteCity(connection, 3);
                Console.WriteLine("After- After");
                foreach (var city in cities)
                {
                    Console.WriteLine(city.Name);
                }


            }


        }
    }
}
