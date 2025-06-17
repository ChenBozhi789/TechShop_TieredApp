using Models;

namespace RestApi.Client
{
    public interface IProductClient
    {
        Task<int> AddAsync(ProductModel model);
        void DeleteAsync(int id);
        Task<ProductModel> GetAsync(int id);
        Task<List<ProductModel>> GetAllAsync();
        Task<IList<ProductModel>> ListAsync();
        Task<int> UpdateAsync(ProductModel model);
    }
}