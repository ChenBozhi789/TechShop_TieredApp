using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class OrderModel : IOrderModel
    {
        [Required]
        [JsonPropertyName("orderId")]
        public int OrderID { get; set; }

        // Foreign Key
        [Required]
        [JsonPropertyName("productId")]
        public int ProductID { get; set; }

        [Required]
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [Required]
        [JsonPropertyName("amount")]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(100)]
        [JsonPropertyName("customerName")]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("number")]
        public string Number { get; set; }

        [Required]
        [StringLength(20)]
        [JsonPropertyName("orderStatus")]
        public string OrderStatus { get; set; }

        [Required]
        [JsonPropertyName("timeStamp")]
        public DateTime TimeStamp { get; set; }
    }
}
