namespace PolovniAutomobiliMVC.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Car Car { get; set; }
        public Order Order { get; set; }
    }
}
