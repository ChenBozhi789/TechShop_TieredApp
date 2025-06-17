using AutoMapper;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        protected IUnitOfWork UnitOfWork { get; private set; }

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void AddLaptop(LaptopModel laptopModel)
        {
            if (string.IsNullOrWhiteSpace(laptopModel.Name))
            {
                throw new ArgumentException("The product name cannot be left blank.");
            }

            // Map LaptopModel to Laptop entity
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LaptopModel, Laptop>();
            });

            IMapper mapper = new Mapper(config);
            var entity = mapper.Map<Laptop>(laptopModel);

            entity.LastModifiedDate = DateTime.Now;

            UnitOfWork.ProductRepository.Add(entity);
            UnitOfWork.Save();
        }

        public void AddDesktop(DesktopModel desktopModel)
        {
            if (string.IsNullOrWhiteSpace(desktopModel.Name))
            {
                throw new ArgumentException("The product name cannot be left blank.");
            }

            var entity = _mapper.Map<Desktop>(desktopModel);

            entity.LastModifiedDate = DateTime.Now;

            UnitOfWork.ProductRepository.Add(entity);
            UnitOfWork.Save();
        }

        public List<ProductModel> GetAll()
        {
            var entities = UnitOfWork.ProductRepository.GetAll();
            return _mapper.Map<List<ProductModel>>(entities);
        }

        public ProductModel Get(int productId)
        {
            var entity = UnitOfWork.ProductRepository.Get(productId);

            if (entity is Laptop laptop)
            {
                return _mapper.Map<LaptopModel>(laptop);
            }
            else if (entity is Desktop desktop)
            {
                return _mapper.Map<DesktopModel>(desktop);
            }

            return _mapper.Map<ProductModel>(entity);
        }

        public void UpdateProduct(ProductModel productModel)
        {
            if (string.IsNullOrWhiteSpace(productModel.Name))
                throw new ArgumentException("Product name cannot be empty");

            // 从数据库加载实体，确保是 EF Core 跟踪的对象
            // Load the entity from database. Concept: Tracked Entity
            var existingEntity = UnitOfWork.ProductRepository.Get(productModel.ProductID);
            if (existingEntity == null)
                throw new InvalidOperationException("Product not found");

            // Update general fields
            existingEntity.Name = productModel.Name;

            existingEntity.ProductType = productModel.ProductType;
            existingEntity.Price = productModel.Price;
            existingEntity.StockQuantity = productModel.StockQuantity;
            existingEntity.BrandID = productModel.BrandID;
            existingEntity.Description = productModel.Description;

            existingEntity.CPU = productModel.CPU;
            existingEntity.GPU = productModel.GPU;
            existingEntity.Memory = productModel.Memory;
            existingEntity.LastModifiedDate = DateTime.Now;

            // Handle laptop fields
            if (existingEntity is Laptop laptop && productModel is LaptopModel laptopModel)
            {
                laptop.BatteryLife = laptopModel.BatteryLife;
                laptop.Weight = laptopModel.Weight;
            }
            // Handle desktop fields
            else if (existingEntity is Desktop desktop && productModel is DesktopModel desktopModel)
            {
                desktop.TowerSize = desktopModel.TowerSize.ToString();
                desktop.PowerSupplyWattage = desktopModel.PowerSupplyWattage;
                desktop.CoolingSystem = desktopModel.CoolingSystem;
            }

            UnitOfWork.ProductRepository.Update(existingEntity);
            UnitOfWork.Save();
        }

        public void DeleteProduct(ProductModel productModel)
        {
            var deletingEntity = UnitOfWork.ProductRepository.Get(productModel.ProductID);
            if (deletingEntity == null)
                throw new InvalidOperationException("Product not found");

            UnitOfWork.ProductRepository.Delete(deletingEntity);
            UnitOfWork.Save();
        }
    }
}
