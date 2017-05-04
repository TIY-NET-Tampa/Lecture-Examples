using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homereview__Events.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public Guid BarCode { get; set; } = Guid.NewGuid();

        [DataType(DataType.DateTime)]
        public DateTime? DatePurchased { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double PurchasedPrice { get; set; }

        public bool WasUsed { get; set; } = false;

        // navigation prop
        public int EventId { get; set; }
        public EventModel Event { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}