using HomeWorkReview_AquariumsAndEF.Datacontext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkReview_AquariumsAndEF
{
    class Program
    {
        /*
         Questions:
         - SQL Queries?!?
         - how to call the middle table, joins & middle tables
         - When to use a join statement and when not to
         - creating that table 
         - Db schema is different from what you imgined
         - JSON Serialization for APIs....

             */

        static void Main(string[] args)
        {
            // Given and AQ NAme, what Aquatic Life is there

            var db = new AquaContext();

            var query1 = db.AquariumAquaticLifeOcean
                .Include(i => i.Aquarium)
                .Include(i => i.AquaticLife)
                .Include(i => i.Ocean)
                .Where(w => w.Aquarium.Name == "Fish Tank");

            foreach (var item in query1)
            {
                Console.WriteLine(item.AquaticLife.Name);
            }

        }
    }
}
