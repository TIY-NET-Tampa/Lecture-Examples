using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    public class User
    {
        [JsonProperty(PropertyName="name")]
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j","password");
            client.Connect();


            var users = client.Cypher
                 .Match("(u:User)")
                 .Return(u => u.As<User>())
                 .Results;

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name}");
            }

            Console.ReadLine();
        }
    }
}
