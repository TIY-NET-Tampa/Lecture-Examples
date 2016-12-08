using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SimpleExample
{
    class Program
    {
        static List<City> ReadFromCities(SqlConnection conn)
        {
            var rv = new List<City>();
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"SELECT Id, City, State, Population FROM City";

                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var id = reader["Id"];
                    var cityName = reader[1];
                    var state = reader[2];
                    var population = reader[3];
                    var city = new City {
                        Id = (int)id,
                        Name = cityName as string,
                        State = state as string,
                        Population = population as int? 
                    };
                    rv.Add(city);
                }
                conn.Close();
            }
            return rv;
        }

        static void AddCity(SqlConnection conn, City cityToAdd)
        {
            using(var cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"INSERT INTO City (City, State, Population)" +
                                    "Values (@City, @State, @Population)";

                cmd.Parameters.AddWithValue("@City", cityToAdd.Name);
                cmd.Parameters.AddWithValue("@State", cityToAdd.State);
                cmd.Parameters.AddWithValue("@Population", cityToAdd.Population);

                cmd.ExecuteNonQuery();
            }
        }

        static void UpdateCity(SqlConnection conn, City newCity)
        {
            using (var cmd = new SqlCommand())
            {
                // What database to use
                cmd.Connection = conn;
                
                // What query to run
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"UPDATE City "+
                                    "SET City=@City, State=@State, Population=@Population "+
                                    "WHERE Id=@Id";

                // What values to use
                cmd.Parameters.AddWithValue("@City", newCity.Name);
                cmd.Parameters.AddWithValue("@State", newCity.State);
                cmd.Parameters.AddWithValue("@Population", newCity.Population);

                cmd.Parameters.AddWithValue("@Id", newCity.Id);

                // Run it
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        static void DeleteCity(SqlConnection conn, int cityId)
        {
            using (var cmd = new SqlCommand())
            {
                // What database Am i using?
                cmd.Connection = conn;

                // What am i doing?
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"DELETE " +
                                    "FROM City "+
                                    "WHERE Id=@Id";

                // What am i doing with?
                cmd.Parameters.AddWithValue("@Id", cityId);

                // Lets do it
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        static void Main(string[] args)
        {
            var connectionStrings = @"Server=localhost\SQLEXPRESS;Database=DistinctExample;Trusted_Connection=True;";
            using(var connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                Console.WriteLine("Connected!!!!");
                connection.Close();
                // ADDING A CITY FROM CONSOLE
                //Console.WriteLine("Enter the city you want to add in this format: name, state, population");
                //var input = Console.ReadLine();
                //var values = input.Split(',');
                //var newCity = new City
                //{
                //    Name = values[0],
                //    State = values[1],
                //    Population = int.Parse(values[2])
                //};
                //AddCity(connection, newCity);

                
                var cities = ReadFromCities(connection);
                foreach(var city in cities)
                {
                    Console.WriteLine(city);
                }
                // UPDATING City
                //Console.WriteLine("What city do you want to update, enter in csv format");
                //var input = Console.ReadLine();
                //var values = input.Split(',');
                //var newCity = new City
                //{
                //    Id = int.Parse(values[0]),
                //    Name = values[1],
                //    State = values[2],
                //    Population = int.Parse(values[3])
                //};
                //UpdateCity(connection, newCity);

                // Delete a city
                Console.WriteLine("What city do you want to delete?");
                var id = int.Parse(Console.ReadLine());
                DeleteCity(connection, id);
                Console.ReadLine();
            }

        }
    }
}
