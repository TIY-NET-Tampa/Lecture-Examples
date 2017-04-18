using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkReview_AquariumsAndEF.Models
{
    class AquaticLIfe
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime DataAddedToTank { get; set; } = DateTime.Now;

        public virtual ICollection<Aquarium> Aquariums { get; set; } = new HashSet<Aquarium>();
        public virtual ICollection<Ocean> Oceans { get; set; } = new HashSet<Ocean>();
    }
}
