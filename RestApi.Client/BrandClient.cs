using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace RestApi.Client
{
    public class BrandClient : ClientBase, IBrandClient
    {
        public BrandClient(IApiConfiguration configuration, HttpClient httpClient) : base(configuration, httpClient)
        {

        }

        public async Task<BrandModel> GetAsync(int id)
        {
            return await GetAsync<BrandModel>($"/api/brand/{id}");
        }

        public async Task<List<BrandModel>> GetAllAsync()
        {
            return await GetAsync<List<BrandModel>>("/api/brand");
        }

        public async Task<IList<BrandModel>> ListAsync()
        {
            return await GetAsync<IList<BrandModel>>("/api/brand");
        }

        public async Task<int> AddAsync(BrandModel model)
        {
            return await AddAsync("/api/brand", model);
        }

        public async Task<int> UpdateAsync(BrandModel model)
        {
            return await UpdateAsync("/api/brand", model);
        }

        public void DeleteAsync(int id)
        {
            DeleteAsync($"/api/brand/{id}");
        }
    }
}
