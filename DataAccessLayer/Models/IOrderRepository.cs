using System.Collections;

namespace DataAccessLayer.Models
{
    public interface IOrderRepository
    {
        void Add(Order instance);
        void Delete(int id);
        void Delete(Order instance);
        Order Get(int id);
        IEnumerable List();
        void Update(Order instance);
    }
}