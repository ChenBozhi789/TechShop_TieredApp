
namespace Models
{
    public interface IProductModel
    {
        int BrandID { get; set; }
        string CPU { get; set; }
        string Description { get; set; }
        string GPU { get; set; }
        DateTime LastModifiedDate { get; set; }
        string Memory { get; set; }
        string Name { get; set; }
        IList<IOrderModel> Orders { get; set; }
        decimal Price { get; set; }
        int ProductID { get; set; }
        string ProductImage { get; set; }
        DateTime PublishedDate { get; set; }
        int StockQuantity { get; set; }
    }
}