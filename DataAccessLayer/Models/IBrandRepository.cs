using System.Collections;

namespace DataAccessLayer.Models
{
    public interface IBrandRepository
    {
        void Add(Brand instance);
        Brand Get(int id);
        List<Brand> GetAll();
        void Update(Brand instance);
        void Delete(Brand instance);
        void Delete(int id);        
        IEnumerable List();        
    }
}