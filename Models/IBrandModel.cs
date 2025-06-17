
namespace Models
{
    public interface IBrandModel
    {
        int BrandID { get; set; }
        string Country { get; set; }
        string Manufacturer { get; set; }
        string Name { get; set; }
        IList<IProductModel> Products { get; set; }
        string Website { get; set; }
    }
}