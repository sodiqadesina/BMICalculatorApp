using BMICalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BMICalculatorApp.Controllers
{
    public class BmiController : Controller
    {
        [HttpGet()]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public IActionResult Index(BmiViewModel bmiViewModel)

          
        {

            if (ModelState.IsValid)
            {
                bmiViewModel.Bmi = bmiViewModel.CalcBmi(bmiViewModel.Height, bmiViewModel.Weight);

                bmiViewModel.BmiSummary = bmiViewModel.GetBmiResultSummary(bmiViewModel.Bmi);

                return View(bmiViewModel);
            }else
            {
                return View(null);
            }
       
        
        }
    }
}
