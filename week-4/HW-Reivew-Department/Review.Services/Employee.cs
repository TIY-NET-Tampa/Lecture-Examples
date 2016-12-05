using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Review.Services
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string  Email { get; set; }
        public string Phone { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

    }
}
