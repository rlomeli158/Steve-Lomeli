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

        public Int32 TransactionNumber { get; set; } //Will we need this?

        public DateTime OrderDate { get; set; }

        public Decimal OrderSubtotal
        {
            get { return Tickets.Sum(t => t.TotalCost); }
        }

        public Decimal Taxes
        {
            get { return OrderSubtotal * SALES_TAX_RATE; }
        }

        public Decimal OrderTotal
        {
            get { return OrderSubtotal + Taxes; }
        }

        public List<Ticket> Tickets { get; set; }

        public AppUser User { get; set; } //Customer that bought

        public Order()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }


    }
}
