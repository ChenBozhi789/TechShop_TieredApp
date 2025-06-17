using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class BrandModel : IBrandModel
    {
        [JsonPropertyName("brandId")]
        public int BrandID { get; set; }

        [Required]
        [StringLength(100)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("website")]
        public string Website { get; set; }

        [Required]
        [JsonPropertyName("products")]
        public IList<IProductModel> Products { get; set; }

        public BrandModel()
        {
            Products = new List<IProductModel>();
        }
    }

}
