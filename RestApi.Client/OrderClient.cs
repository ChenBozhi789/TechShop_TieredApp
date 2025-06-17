using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace RestApi.Client
{
    public class OrderClient : ClientBase, IOrderClient
    {
        public OrderClient(IApiConfiguration configuration, HttpClient httpClient) : base(configuration, httpClient)
        {

        }

        public async Task<OrderModel> GetAsync(int id)
        {
            return await GetAsync<OrderModel>($"/api/order/{id}");
        }

        public async Task<IList<OrderModel>> ListAsync()
        {
            return await GetAsync<IList<OrderModel>>("/api/order/names");
        }

        public async Task<int> AddAsync(OrderModel model)
        {
            return await AddAsync("/api/order", model);
        }

        public async Task<int> UpdateAsync(OrderModel model)
        {
            return await UpdateAsync("/api/order", model);
        }

        public void DeleteAsync(int id)
        {
            DeleteAsync($"/api/order/{id}");
        }
    }
}
