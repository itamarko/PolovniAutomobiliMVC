using Microsoft.EntityFrameworkCore;

namespace PolovniAutomobiliMVC.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _db;

        public CarRepository(AppDbContext dbContext)
        {
            this._db = dbContext;
        }
        public IEnumerable<Car> AllCars => _db.Cars.Include(c => c.Category);

        public IEnumerable<Car> SpecialOfferCars => _db.Cars.Include(c => c.Category).Where(c=> c.IsSpecialOffer);


        public Car GetCarById(int id)
        {
            return _db.Cars.Find(id);
        }
    }
}
