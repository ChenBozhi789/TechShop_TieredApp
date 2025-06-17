using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;

        // Entity collection
        public ICollection<Product>? Products { get; set; }
    }

}
