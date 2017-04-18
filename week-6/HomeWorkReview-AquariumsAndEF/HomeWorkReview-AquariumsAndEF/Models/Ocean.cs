using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkReview_AquariumsAndEF.Models
{
    class Ocean
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double AverageTemp { get; set; }

        public virtual ICollection<AquaticLIfe> AquaticLife { get; set; } = new HashSet<AquaticLIfe>();
    }
}
