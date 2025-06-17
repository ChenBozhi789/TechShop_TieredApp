
namespace Models
{
    public interface IOrderModel
    {
        decimal Amount { get; set; }
        string CustomerName { get; set; }
        string Email { get; set; }
        string Number { get; set; }
        int OrderID { get; set; }
        string OrderStatus { get; set; }
        int ProductID { get; set; }
        int Quantity { get; set; }
        DateTime TimeStamp { get; set; }
    }
}