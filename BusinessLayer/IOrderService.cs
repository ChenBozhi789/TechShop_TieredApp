using DataAccessLayer.Models;
using Models;

namespace BusinessLayer
{
    public interface IOrderService
    {
        Order Add(OrderModel orderModel);
    }
}