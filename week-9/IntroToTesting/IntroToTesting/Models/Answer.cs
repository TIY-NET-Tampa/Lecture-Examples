using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToTesting.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public DateTime DateCalculated { get; set; } = DateTime.Now;
    }
}
