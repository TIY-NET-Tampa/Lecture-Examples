using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Customer> Customers {get;set;} = new HashSet<Customer>();
    }
}
