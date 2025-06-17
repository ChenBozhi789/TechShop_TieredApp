using Models;

namespace BusinessLayer
{
    public interface IProductService
    {
        void AddDesktop(DesktopModel desktopModel);
        void AddLaptop(LaptopModel laptopModel);
        void DeleteProduct(ProductModel productModel);
        ProductModel Get(int productId);
        List<ProductModel> GetAll();
        void UpdateProduct(ProductModel productModel);
    }
}