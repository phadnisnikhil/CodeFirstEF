using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEF.Controllers
{
    [Route("Nikhil")]
    public class PilotController : Controller
    {

        private readonly Calculator _calculator;
        public PilotController(Calculator calculator)
        {
            _calculator = calculator;

        }
        [Route("NikIndex")]
        public IActionResult Index()
        {
            List<int> resultSet = new List<int>();
            resultSet.Add(_calculator.Add(10, 20));
            resultSet.Add(_calculator.Subtract(100,50));
            resultSet.Add(_calculator.Multiply(10, 20));
            resultSet.Add(_calculator.Divide(100, 10));
            ViewBag.resultSet = resultSet;
            return View();
        }
    }
}
