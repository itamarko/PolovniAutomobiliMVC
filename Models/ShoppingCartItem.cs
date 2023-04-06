namespace PolovniAutomobiliMVC.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
