using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExamples
{
    class Program
    {

        public async static Task DoSomething()
        {
            await Task.Run(() =>
             {
                 Thread.Sleep(5000);
                 Console.WriteLine("This is my async task");
             });
            Console.WriteLine("Here I am!");
        }


        public async static Task<int> GetMyCount()
        {
            return 5; 
        }

        public async static void CallGetMyCount()
        {
            var myCount = await GetMyCount();
        }

        public async static Task<string> CallWebServerAsync()
        {
            var url = "http://swapi.co/api/people/1";
            var request = WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";

            var body = String.Empty;
            var response = await request.GetResponseAsync();
            using(var reader = new StreamReader(response.GetResponseStream()))
            {
                body = await reader.ReadToEndAsync();
            }
            return body;            
        }

       public  static string CallWebServer()
        {
            var url = "http://swapi.co/api/people/1";
            var request = WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";

            var rawResponse = String.Empty;
            var response =  request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse =  reader.ReadToEnd();
            }
            return rawResponse;
        }


        static void Main(string[] args)
        {

            DoSomething().Wait();
            var myCount = GetMyCount().Result;
            

            Console.WriteLine("called my async function");
            Console.ReadLine();
        }
    }
}
