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
            // AddSingleton 创建一个通用的服务实例，所有请求都使用同一个实例。
            // AddTransient 创建一个服务实例，每次请求都会创建一个新的实例。一次性使用。
            // AddScoped 创建一个服务实例，每次请求都会创建一个新的实例。
            container.AddScoped<IBrandService, BrandService>();
            container.AddScoped<IProductService, ProductService>();
            container.AddScoped<IOrderService, OrderService>();

            return container;
        }
    }
}
