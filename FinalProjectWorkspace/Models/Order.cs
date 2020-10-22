using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{

    public class Order
    {
        private const Decimal SALES_TAX = 0.0825m;

        public Int32 OrderID { get; set; }

        public Int32 TransactionNumber { get; set; } //Will we need this?

        public DateTime OrderDate { get; set; }

        public Decimal OrderSubtotal
        {
            get { return Tickets.Sum(t => t.TotalCost); }
        }

        public Decimal Taxes
        {
            get { return OrderSubtotal * SALES_TAX; }
        }

        public Decimal OrderTotal
        {
            get { return OrderSubtotal + Taxes; }
        }

        public List<Ticket> Tickets { get; set; }

        //public Customer Customer { get; set; } or public AppUser User {get;set;} ?

        public Order()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }


    }
}
