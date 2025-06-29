namespace DataAccessLayer.Models
{
    public interface IUnitOfWork
    {
        IRepository<Brand> BrandRepository { get; }
        IRepository<Order> OrderRepository { get; }
        IRepository<Product> ProductRepository { get; }

        void Dispose();
        void Save();
    }
}