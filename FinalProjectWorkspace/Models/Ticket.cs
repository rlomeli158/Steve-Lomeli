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
        Matinee,
        Tuesday_Discount,
        Senior_Discounts,
        Tuesday_and_Senior,
        Matinee_and_Senior,
        Weekday_Discount
    }

    public enum TicketTypes
    {
        Weekday_Regular,
        Weekend_Regular,
        Special_Event
    }

    //Should be individual tickets
    public class Ticket
    {
        public Int32 TicketID { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TicketPrice { get; set; }

        public DiscountNames DiscountName { get; set; }

        public TicketTypes TicketType { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal DiscountAmount { get; set; } 

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCost { get; set; }

        //Seats purchased
        //[Required(ErrorMessage = "Please select a seat.")]
        public String SeatNumber { get; set; }

        public Decimal TransactionPopcornPoints { get; set; }

        //to see if ticket is cancelled or not
        public String TicketStatus{ get; set; }

        public Order Order { get; set; }
        public Showing Showing { get; set; }


    }
}
