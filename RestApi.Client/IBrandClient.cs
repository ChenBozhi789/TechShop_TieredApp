using Models;

namespace RestApi.Client
{
    public interface IBrandClient
    {
        Task<int> AddAsync(BrandModel model);
        void DeleteAsync(int id);
        Task<BrandModel> GetAsync(int id);
        Task<List<BrandModel>> GetAllAsync();
        Task<IList<BrandModel>> ListAsync();
        Task<int> UpdateAsync(BrandModel model);
    }
}