using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview
{
    // Constructor Example
    public class Dog
    {
        public string Name { get; set; }
        public string FurColor { get; set; }
        public string Breed { get; set; }
        public bool IsHappy { get; set; } = true;
        public bool HasTail { get; set; }

        public bool IsWaggingTail
        {
            get
            {
                return (this.HasTail && this.IsHappy);
            }
        }

        public int Age { get; set; } = 0;

        public Dog(string name, string furcolor, string breed)
        {
            Console.WriteLine("Creating a dog");
            this.Name = name;
            this.FurColor = furcolor;
            this.Breed = breed;
        }


    }
    
    public class School
    {
        public double Teachers { get; set; }
        public double Students { get; set; }
        private static int GCD(int a, int b)
        {
            while (b > 0)
            {
                var rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }

        public string TeacherStudentRatio()
        {
            var biggest = 0d;
            var smallest = 0d;
            if (Teachers >= Students)
            {
                biggest = Teachers;
                smallest = Students;
            }
            else
            {
                biggest = Students;
                smallest = Teachers;
            }

            var gcd = GCD((int)smallest, (int)biggest);
            
            var teacher = this.Teachers / gcd;
            var students = this.Students / gcd;
            var rv = $"{teacher} : {students}";
            return rv;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Should be 5
            // 5 / 20 = 0 R 5
            var x = 5 % 20;
            // should be 4
            // 4 / 24 = 0 R 4
            var y = 4 % 24;
            var z = 50 % 5;

            //should be 2 
            // 12 / 5 = 2 R 2
            var r1 = 12 % 5;

            // should be 1
            // 11 / 10 = 1 R 1
            var r2 = 11 % 10;

            // should 1
            // 31 / 10 = 3 R 1
            var r3 = 31 % 10;



            var highSchool = new School { Students = 20, Teachers = 5 };
            var middleSchool = new School { Students = 10, Teachers = 2 };
            var elementary = new School { Students = 42, Teachers = 5 };

            // should  == 1:4;
            var ratio = highSchool.TeacherStudentRatio();

            // should  == 1:2;
            var ratio2 = middleSchool.TeacherStudentRatio();

            // should  == 5:42;
            var ratio3 = elementary.TeacherStudentRatio();


            Console.WriteLine(ratio);

            Console.WriteLine(ratio2);

            Console.WriteLine(ratio3);
            Console.ReadLine();
        }
    }
}
