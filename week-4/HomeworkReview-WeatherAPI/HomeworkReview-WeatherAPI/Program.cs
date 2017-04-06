using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview_WeatherAPI
{
    class Program
    {

        /*
         Questions:
         - X Wanted to store the entire weather return in to the db
         - open/closing connection in method vs in the main
         - X classes
         - X past locations
             */

        public static bool PastLocations(string userNames)
        {
            var rv = false;
            using (var connection = new SqlConnection(connectionStrings))
            {
                var query = $"SELECT * FROM Data WHERE UserName = '{name}'";
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                var reader = cmd.ExecuteReader();
                rv = reader.HasRows;
                if (reader.HasRows)
                {
                    Console.WriteLine("Welcome Back");
                }
                else
                {
                    Console.WriteLine("Welcome to wetherman!!!!!");
                }
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["TimeOfRequest"]}-- {reader["Temp"]}");
                }
                connection.Close();
            }
            return rv;

        }

        public static void SaveLocation(string userName, string temp, string cc, string data)
        {
            using (var connection = new SqlConnection(connectionStrings))
            {
                var query = $"INSERT INTO [dbo].[Data] ([UserName],[CurrentCondition],[Temp],[RawRequest]) " +
                             $"VALUES ('{userName}','{cc}',{temp},'{data}')";

                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void SaveLocation2(SqlConnection connection, string userName, string temp, string cc, string data)
        {
            var query = $"INSERT INTO [dbo].[Data] ([UserName],[CurrentCondition],[Temp],[RawRequest]) " +
                           $"VALUES ('{userName}','{cc}',{temp},'{data}')";

            var cmd = new SqlCommand(query, connection);


            cmd.ExecuteNonQuery();
        }
        const string connectionStrings = @"Server=localhost\SQLEXPRESS;Database=Weather;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name");
            var name = Console.ReadLine().ToLower();

            PastLocations(name);

            Console.WriteLine("Zip?!?!?");
            var zip = "33716";//Console.ReadLine();

            var token = "eec8464744e5e3cfa8e6f4f2f612df10";
            var url = $"http://api.openweathermap.org/data/2.5/weather?zip={zip},us&appid={token}&units=imperial";

            Console.WriteLine($"Going to the url: {url}");

            var request = WebRequest.Create(url);
            var rawResponse = String.Empty;
            var response = request.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = reader.ReadToEnd();
            }

            var weatherData = JsonConvert.DeserializeObject<RootObject>(rawResponse);
            var currentCond = weatherData.weather.First().description;
            var temp = weatherData.main.temp;
            Console.WriteLine("Your weather is:");
            Console.WriteLine($"{temp} Degrees");
            Console.WriteLine($"{currentCond}");
            SaveLocation(name, temp.ToString(), currentCond, rawResponse);

            // store the data 

            using (var connection = new SqlConnection(connectionStrings))
            {
                connection.Open();
                SaveLocation2(connection, name, temp.ToString(), currentCond, rawResponse);
                SaveLocation2(connection, name, temp.ToString(), currentCond, rawResponse);

                SaveLocation2(connection, name, temp.ToString(), currentCond, rawResponse);

                SaveLocation2(connection, name, temp.ToString(), currentCond, rawResponse);

                connection.Close();
            }

          

        }
    }
}
