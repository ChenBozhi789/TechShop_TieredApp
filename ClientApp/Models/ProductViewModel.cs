using Models;

namespace ClientApp.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }

        public IList<ProductModel> Products { get; set; }
        public IList<BrandModel> Brands { get; set; }
    }
}
