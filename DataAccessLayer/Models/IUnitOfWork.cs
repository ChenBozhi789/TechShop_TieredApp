namespace DataAccessLayer.Models
{
    public interface IUnitOfWork
    {
        IBrandRepository BrandRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository ProductRepository { get; }

        void Dispose();
        void Save();
    }
}