using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview_TownWithClass
{
    class House
    {
        public string Name { get; set; }
        private string BuildingType { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int NumberOfFloors { get; set; }
        // ReadOnly Property Square Footage
        public double SquareFootage
        {
            get
            {
                return Length * Width * NumberOfFloors;
            }
        }


        // full address = Address1 Address2 City, State, Zip
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public string FullAddress
        {
            get
            {
                return $"{Address1} {Address2} {City}, {State}, {Zip}";
            }
        }

        public House(string buildingType)
        {
            this.BuildingType = buildingType;
            Console.WriteLine("Hello from the ctor w/ string");
        }

        public House()
        {
            Console.WriteLine("hello from the default ctor");
        }

        public House(int numOfBedroom)
        {
            Console.WriteLine("Hello from 1 int");
            this.NumberOfBedrooms = numOfBedroom;
            this.NumberOfBathrooms = numOfBedroom / 2;
        }


        public House(int numOfBathrooms, string name)
        {

        }
        public House(string name, int numOfBedroom)
        {

        }
        private string ReturntheBuildingType()
        {
            return this.BuildingType;
        }


        private List<Person> Occupants { get; set; } = new List<Person>();


        public void AddPersonToBuilding(Person peep)
        {
            this.Occupants.Add(peep);
        }

        public void RemovePersonFromBuilding(Person peep)
        {
            this.Occupants.Remove(peep);
        }
    }
}
