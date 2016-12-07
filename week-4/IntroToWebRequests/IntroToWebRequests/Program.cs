using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace IntroToWebRequests
{
    class Program
    {
        static void GetCharacter()
        {
            // 
            var url = "http://swapi.co/api/people/1";
            // create the request with the url -- so this is where we are going
            var request = WebRequest.Create(url);
            // this is asking the server to repsonse with json
            request.ContentType = "application/json; charset=utf-8";

            // now we need someplace to store the raw data resposne
            var rawResponse = String.Empty;

            // Going out and reading the response
            var response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                // reading the response into a string. 
                rawResponse = reader.ReadToEnd();
            }

            // using Newtonsoft.json to convert the raw data into a POCO (Plain Old C# Object) 
            var luke = JsonConvert.DeserializeObject<Character>(rawResponse);

            Console.WriteLine("Raw data");
            Console.WriteLine(rawResponse);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(luke.eye_color);
            //Console.ReadLine();

        }


        static void Main(string[] args)
        {
            GetCharacter();
            GetPlanet();
            WeatherApiDemo();
        }

        static void WeatherApiDemo()
        {

            var token = "eec8464744e5e3cfa8e6f4f2f612df10";
            var url = "http://api.openweathermap.org/data/2.5/weather?zip=33716,us&appid=" + token;
            Console.WriteLine(url);
            Console.ReadLine();
        }

        private static void GetPlanet()
        {
            var url = "http://swapi.co/api/planets/2";

            var request = WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";
            var rawJson = String.Empty;
            var response = request.GetResponse();
            using(var reader = new StreamReader(response.GetResponseStream()))
            {
                rawJson = reader.ReadToEnd();
            }
            var planet = JsonConvert.DeserializeObject<Planet>(rawJson);
            Console.WriteLine(planet.name);
            Console.ReadLine();
        }
    }
}
