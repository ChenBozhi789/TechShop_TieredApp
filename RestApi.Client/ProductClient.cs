using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace RestApi.Client
{
    public class ProductClient : ClientBase, IProductClient
    {
        public ProductClient(IApiConfiguration configuration, HttpClient httpClient) : base(configuration, httpClient)
        {

        }

        public async Task<ProductModel> GetAsync(int id)
        {
            return await GetAsync<ProductModel>($"/api/product/{id}");
        }

        public async Task<List<ProductModel>> GetAllAsync()
        {
            return await GetAsync<List<ProductModel>>("/api/product");
        }


        public async Task<IList<ProductModel>> ListAsync()
        {
            return await GetAsync<IList<ProductModel>>("/api/product/names");
        }

        public async Task<int> AddAsync(ProductModel model)
        {
            return await AddAsync("/api/product", model);
        }

        public async Task<int> UpdateAsync(ProductModel model)
        {
            return await UpdateAsync("/api/product", model);
        }

        public void DeleteAsync(int id)
        {
            DeleteAsync($"/api/product/{id}");
        }
    }
}
