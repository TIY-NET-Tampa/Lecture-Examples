using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview_TownWithClass
{
    /* Questions:
        X Access Rights (public / private or ReadOnly vs WriteOnly  or get/set)
        X Full Address how does that look?
        X constructors & when do to use them
        X use of the classes that were created
        - idea of level 3 -- "Walking Person"
    */
    class Program
    {
        static void Main(string[] args)
        {
            // lambdaCast <- podcast on func programming

            var myHouse = new House("brick");


            var hank = new Person { Name = "Hank" };

            myHouse.Occupants.Add(hank);

          
            var myBeachHouse = new House();

            var newHouse = new House(5, "My House")
            {
                Height = 10,
                Length = 30,
                Width = 40
            };

            myHouse.Height = 20;
            myHouse.Width = 30;
            myHouse.Length = 40;


            // a list houses
            var villageBlock = new List<House>();

            villageBlock.Add(myHouse);
            villageBlock.Add(myBeachHouse);


           // var getIt = myHouse.ReturntheBuildingType();
        }
    }
}
