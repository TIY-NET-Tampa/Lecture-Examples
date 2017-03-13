using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{
    class Program
    {
        static void Main(string[] args)
        {

            var consoleLogger = new ConsoleLogger();
            var fileLogging = new FileLogger();

            var shop = new Shop(fileLogging);
            var otherShop = new Shop(consoleLogger);


            var turbo = new RaceCar();
            var monster = new Truck();
            var family = new Sedan();

         
            var myCars = new List<IHasOil>();
            myCars.Add(turbo);
            myCars.Add(monster);
            myCars.Add(family);

            var myWheels = new List<IHasTires>()
            {
                new RaceCar(),
                new Bicycle()
            };
         

            myWheels.ForEach(thing => shop.ChangeTire(thing));

            myCars.ForEach(car => shop.ChangeCarsOil(car));

            Console.ReadLine();




        }
    }
}
