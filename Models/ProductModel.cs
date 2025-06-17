using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class ProductModel : IProductModel
    {
        [Required]
        [JsonPropertyName("productId")]
        public int ProductID { get; set; }

        // Foreign Key
        [Required]
        [JsonPropertyName("brandId")]
        public int BrandID { get; set; }

        [Required]
        [StringLength(100)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Required]
        [JsonPropertyName("price")]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("productImage")]
        public string ProductImage { get; set; }

        [Required]
        [JsonPropertyName("publishedDate")]
        public DateTime PublishedDate { get; set; }

        [JsonPropertyName("stockQuantity")]
        public int StockQuantity { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("productType")]
        public string ProductType { get; set; }        

        [Required]
        [JsonPropertyName("lastModifiedDate")]
        public DateTime LastModifiedDate { get; set; }

        [Required]
        [StringLength(100)]
        [JsonPropertyName("cpu")]
        public string CPU { get; set; }

        [Required]
        [StringLength(100)]
        [JsonPropertyName("gpu")]
        public string GPU { get; set; }

        [Required]
        [StringLength(100)]
        [JsonPropertyName("memory")]
        public string Memory { get; set; }

        [JsonPropertyName("orders")]
        public IList<IOrderModel> Orders { get; set; }

        public ProductModel()
        {
            Orders = new List<IOrderModel>();
        }
    }
}
