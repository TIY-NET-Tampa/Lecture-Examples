using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  YearJoined { get; set; }
        public bool IsActive { get; set; }

        public int? RewardPoints { get; set; }


        public override string ToString()
        {
            return $"{Id}, {Name}, {YearJoined}, {IsActive}";
        }
    }
}
