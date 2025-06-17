using AutoMapper;
using DataAccessLayer.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        protected IUnitOfWork UnitOfWork { get; private set; }

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Order Add(OrderModel orderModel)
        {
            if (string.IsNullOrWhiteSpace(orderModel.CustomerName))
            {
                throw new ArgumentException("The customer name cannot be left blank.");
            }

            // Save new order data
            var entity = _mapper.Map<Order>(orderModel);
            UnitOfWork.OrderRepository.Add(entity);

            // Reduce corresponding Product stock quantity
            var product = UnitOfWork.ProductRepository.Get(orderModel.ProductID);
            if (product == null)
            {
                throw new InvalidOperationException("Product not found.");
            }

            // Inventory check
            if (product.StockQuantity < orderModel.Quantity)
            {
                throw new InvalidOperationException("Not enough stock available.");
            }

            product.StockQuantity -= orderModel.Quantity;

            UnitOfWork.Save();

            return entity;
        }
    }
}
