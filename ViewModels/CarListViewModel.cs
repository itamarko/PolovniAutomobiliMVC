using PolovniAutomobiliMVC.Models;

namespace PolovniAutomobiliMVC.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public string CurrentCategory { get; set; }
    }
}
