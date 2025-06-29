using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class ServiceProviderExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection container)
        {
            container.AddScoped<IUnitOfWork, UnitOfWork>();
            container.AddScoped<IRepository<Brand>, Repository<Brand>>();
            container.AddScoped<IRepository<Product>, Repository<Product>>();
            container.AddScoped<IRepository<Order>, Repository<Order>>();

            return container;
        }

        public static IServiceCollection RegisterDbContext(this IServiceCollection container, string connectionString)
        {
            container.AddDbContext<ModelContext>(options => options.UseSqlServer(connectionString));

            return container;
        }
    }
}
