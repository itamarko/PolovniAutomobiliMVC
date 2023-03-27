namespace PolovniAutomobiliMVC.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> AllCars { get; }
        IEnumerable<Car> SpecialOfferCars { get; }
        Car GetCarById(int id);

    }
}
