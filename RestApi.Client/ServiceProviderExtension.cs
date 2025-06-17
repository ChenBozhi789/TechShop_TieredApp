using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Client
{
    public static class ServiceProviderExtension
    {
        public static IServiceCollection RegisterClients(this IServiceCollection container)
        {
            container.AddHttpClient();
            container.AddScoped<IProductClient, ProductClient>();
            container.AddScoped<IBrandClient, BrandClient>();
            container.AddScoped<IOrderClient, OrderClient>();

            return container;
        }
    }
}
