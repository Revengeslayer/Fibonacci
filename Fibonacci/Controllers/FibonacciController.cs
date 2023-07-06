using Fibonacci.Models;
using Fibonacci.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Controllers
{
    public class FibonacciController : Controller
    {
        private readonly ICalculateService _calculateService;
        public FibonacciController(ICalculateService calculateService)
        {
            _calculateService=calculateService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(FibonacciModel model)
        {
            Console.WriteLine(model.Number);
            if (ModelState.IsValid)
            {
                model.Result = _calculateService.CalculateFibonacci(model.Number);
                return Json(new { success = true, result = model.Result });
            }

            return Json(new { success = false, error = "Invalid input." });
        }
    }
}
