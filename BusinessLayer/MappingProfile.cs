using AutoMapper;
using DataAccessLayer.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MappingProfile : Profile
    {
        // Mapping configuration file
        public MappingProfile()
        {
            CreateMap<Brand, BrandModel>()
                .ForMember(dest => dest.Products, opt => opt.Ignore());
            CreateMap<BrandModel, Brand>()
                .ForMember(dest => dest.Products, opt => opt.Ignore());

            CreateMap<Product, ProductModel>();
            CreateMap<ProductModel, Product>();

            CreateMap<Laptop, LaptopModel>()
                .ForMember(dest => dest.Orders, opt => opt.Ignore());
            CreateMap<LaptopModel, Laptop>();

            CreateMap<Desktop, DesktopModel>();
            CreateMap<DesktopModel, Desktop>();

            CreateMap<Order, OrderModel>();
            CreateMap<OrderModel, Order>();
        }
    }
}
