namespace ClientApp.Models
{
    public class OrderViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }        
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; }
    }
}
