using DataAccessLayer.Models;
using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class ServiceProviderExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection container)
        {            
            container.AddScoped<IBrandService, BrandService>();
            container.AddScoped<IProductService, ProductService>();
            container.AddScoped<IOrderService, OrderService>();

            return container;
        }
    }
}
