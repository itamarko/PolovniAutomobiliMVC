namespace PolovniAutomobiliMVC.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionShort { get; set; }
        public string Description{ get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlThumbnail { get; set; }
        public bool IsSpecialOffer { get; set; }
        public int FuelTypeId { get; set; }
        public Category Category { get; set; }

    }
}
