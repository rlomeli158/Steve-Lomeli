using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum DiscountNames
    {
        None,
        Manitee,
        Tuesday_Discount,
        Senior_Discounts,
        Tuesday_and_Senior,
        Manitee_and_Senior
    }

    //Should be individual tickets
    public class Ticket
    {
        public Int32 TicketID { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TicketPrice { get; set; }

        public DiscountNames DiscountName { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal DiscountAmount { get; set; } //This is how you set a field as nullable, right? Because
                                                    //some people won't have discounts?

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCost { get; set; }

        //Seats purchased
        [Required(ErrorMessage = "Please select a seat.")]
        public String SeatNumber { get; set; } //The strings (seat row & numbers)

        public Decimal TransactionPopcornPoints { get; set; }

        public Order Order { get; set; }
        public Showing Showing { get; set; }


    }
}
