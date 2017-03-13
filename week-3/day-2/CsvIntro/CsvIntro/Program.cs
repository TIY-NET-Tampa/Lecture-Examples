using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvIntro
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "cars.csv";

            //var cars = new List<Car> {
            //    new Car { Name = "Prius", Color="Red" },
            //    new Car { Name = "Civic", Color="Blue" },
            //    new Car { Name = "Tesla", Color="White" }
            //};

            //// To overwrite the file
            //using (var sw = new StreamWriter(filePath))
            //{
            //    foreach (var car in cars)
            //    {
            //        sw.WriteLine($"{car.Name},{car.Color}");
            //    }       
            //}

            ////to append
            //using (var sw = File.AppendText(filePath))
            //{
            //    sw.WriteLine("this is added to the end");
            //    sw.WriteLine("Yup");
            //}


            // TO read a file
            var newCars = new List<Car>();
            using (var sr = new StreamReader(filePath))
            {
                while (sr.Peek() > 0)
                {
                    var line = sr.ReadLine().Split(',');
                    var name = line[0];
                    var color = line[1];
                    newCars.Add(new Car { Name = name, Color = color });
                    //Console.WriteLine(line);
                }
                
            }

            Console.ReadLine();
        }
    }
}
