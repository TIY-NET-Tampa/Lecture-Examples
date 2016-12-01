using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Services
{
    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Number { get; set; }
        public double Salary { get; set; }

        public Stats Statistics { get; set; } = new Stats();

    }
}
