using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{

    public class Order
    {
        private const Decimal SALES_TAX_RATE = 0.0825m; //Verify this is tax rate

        public Int32 OrderID { get; set; }

        [Display(Name ="Transaction Number")]
        public Int32 TransactionNumber { get; set; } //Will we need this?

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        public Decimal OrderSubtotal
        {
            get { return Tickets.Sum(t => t.TotalCost); } //** We have to take off discount amount? 
        }

        public Decimal Taxes
        {
            get { return OrderSubtotal * SALES_TAX_RATE; }
        }

        public Decimal OrderTotal
        {
            get { return OrderSubtotal + Taxes; }
        }

        [Display(Name = "Status")]
        public String OrderStatus { get; set; } //Active or inactive in case it was cancelled

        public List<Ticket> Tickets { get; set; }

        public AppUser Purchaser { get; set; } //Customer that purchased

        public AppUser Recipient { get; set; } //Recipient of gift, if there is one

        public Order()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }

        

    }
}
