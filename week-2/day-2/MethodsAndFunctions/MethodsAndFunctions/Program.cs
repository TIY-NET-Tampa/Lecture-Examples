using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndFunctions
{
    class Program
    {

        static void PrintSomething()
        {
            Console.WriteLine("something");
        }

        static void PrintSomething(string other)
        {
            Console.WriteLine($"something else {other}");
        }



        public void ParkCar(string carName)
        {
            Console.WriteLine($"Pakring {carName}");
        }

        public void ParkCar(string carName, int spacesToTake)
        {
            Console.WriteLine($"Parking {carName}, taking up {spacesToTake} spaces");
        }




        static int AddModifier(string number, int mod)
        {
            return (AddModifier(int.Parse(number), mod));
        }

        static int AddModifier(int number, int modifier = 3)
        {
            return number + modifier;
        }
 
        static void Main(string[] args)
        {
            PrintSomething();

            PrintSomething("Hello cohort!");

            Console.ReadLine();


        }
    }
}
