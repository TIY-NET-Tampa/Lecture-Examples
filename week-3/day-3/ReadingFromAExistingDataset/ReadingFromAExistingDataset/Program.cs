using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFromAExistingDataset
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "../../cars.csv";


            var parkingLot = new List<Car>();

            using(var reader = new StreamReader(filePath))
            {
                // Reading the headers
                var definition = reader.ReadLine();
                var types = reader.ReadLine();

                // reading data
                while(reader.Peek() > 0)
                {
                    var line = reader.ReadLine().Split(';');
                    var car = new Car
                    {
                        CarName = line[0],
                        MPG = double.Parse(line[1]),
                        Cylinders = int.Parse(line[2])
                    };
                    parkingLot.Add(car);
                    
                }
            }

            Console.WriteLine("Our Parking lot has");
            foreach(var car in parkingLot)
            {
                Console.WriteLine($"{car.CarName}, {car.MPG}");
            }
            Console.ReadLine();
        }
    }
}
