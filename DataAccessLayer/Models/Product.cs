using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models

{
    public abstract class Product
    {
        public int ProductID { get; set; }
        public int BrandID { get; set; } // Foreign key
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ProductImage { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public int StockQuantity { get; set; }
        public string ProductType { get; set; } = string.Empty;
        public DateTime LastModifiedDate { get; set; }

        public string CPU { get; set; } = string.Empty;
        public string GPU { get; set; } = string.Empty;
        public string Memory { get; set; } = string.Empty;

        public Brand? Brand { get; set; } // ?
        public ICollection<Order>? Orders { get; set; } // Navigation property
    }

}
