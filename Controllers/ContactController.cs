using Microsoft.AspNetCore.Mvc;

namespace PolovniAutomobiliMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
