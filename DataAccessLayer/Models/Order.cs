using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

        public string CustomerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string OrderStatus { get; set; } = "Pending";

        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public Product? OrderedProduct { get; set; }
    }

}
