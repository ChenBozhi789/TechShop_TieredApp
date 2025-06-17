using Models;

namespace BusinessLayer
{
    public interface IBrandService
    {
        void Add(BrandModel brandModel);
        BrandModel Get(int id);
        List<BrandModel> GetAll();
    }
}