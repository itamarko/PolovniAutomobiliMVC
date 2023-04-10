using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;
using PolovniAutomobiliMVC.ViewModels;

namespace PolovniAutomobiliMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CarController(ICarRepository carRepository, ICategoryRepository categoryRepository)
        {
            _carRepository = carRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(int? categoryId)
        {
            CarListViewModel model = new CarListViewModel()
            {
                Cars = _carRepository.AllCars,
                CurrentCategory = "All cars"
            };

            if (categoryId.HasValue)
            {
                model.Cars = _carRepository.AllCars.Where(c => c.CategoryId == categoryId);
                model.CurrentCategory = _categoryRepository.AllCategories
                                            .Where(c => c.Id == categoryId)
                                            .Select(c => c.Name)
                                            .FirstOrDefault();

            }

            return View(model);
        }

        public IActionResult Details(int id)
        {
            Car car = _carRepository.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
    }
}
