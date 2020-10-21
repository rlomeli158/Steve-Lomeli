using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{

    public class Order
    {
        public Int32 OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        //public Customer Customer { get; set; }

        public List<Ticket> Tickets { get; set; }

        public Order()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }


    }
}
