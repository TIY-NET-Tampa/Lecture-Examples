using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Services
{
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public Department(string name)
        {
            this.Name = name;
        }


        public void AddEmployee(string name, double salary, string phone, string email)
        {
            var emp = new Employee
            {
                Name = name,
                Salary = salary,
                Phone = phone,
                Email = email
            };
            this.Employees.Add(emp);
        }
    }
}
