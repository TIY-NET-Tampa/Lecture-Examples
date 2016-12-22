using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearJoined { get; set; }
        public bool IsActive { get; set; }

        public int? RewardPoints { get; set; }

        public string Email { get; set; }

        public int? AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Movies> Movies { get; set; } = new HashSet<Movies>();

        public override string ToString()
        {
            var rv = $"{Id}, {Name}, {YearJoined}, {IsActive}";
            if (this.Address != null)
            {
                rv += $" and they live at {this.Address.AddressLine}";
            }
            return rv;
        }
    }
}
