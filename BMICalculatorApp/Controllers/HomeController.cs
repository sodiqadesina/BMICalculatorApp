using Microsoft.AspNetCore.Mvc;

namespace BMICalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
