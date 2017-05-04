using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homereview__Events.Models
{
    public class EventModel
    {
        // properties
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string Description { get; set; }

        [DisplayFormat(DataFormatString ="{0:C}")]
        public double Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }


        // navigation properties
        public int VenueId { get; set; }
        public Venue Venue { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public ICollection<Ticket> TicketsSold { get; set; } = new HashSet<Ticket>();
    }
}