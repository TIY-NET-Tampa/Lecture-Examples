using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_And_SQL
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int? Population { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {State}, {Population}";
        }
    }
}
