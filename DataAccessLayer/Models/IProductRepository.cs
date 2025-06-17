using System.Collections;

namespace DataAccessLayer.Models
{
    public interface IProductRepository
    {
        void Add(Product instance);
        void Delete(int id);
        void Delete(Product instance);
        Product Get(int id);
        List<Product> GetAll();
        IEnumerable List();
        void Update(Product instance);
    }
}