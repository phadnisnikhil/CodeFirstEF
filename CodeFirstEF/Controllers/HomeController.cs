using System.Diagnostics;
using CodeFirstEF.Context;
using CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext _empdbContext;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger,EmployeeDbContext EmpDbconnect)
        {
            _logger = logger;
            
            _empdbContext= EmpDbconnect;
        }
       
        public IActionResult Index()
        {
            
            ////var query = from customer in _empdbContext.Employees
            ////            where customer.Name == "Reyansh"
            ////            select customer;
            var query1 = from customer in _empdbContext.userdetails
                        select customer;
            //var dBresult = _empdbContext.Employees.ToList();
            var dBresult1 = _empdbContext.userdetails.ToList();
            // ViewBag.Emp = query.ToList();
            //ViewBag.Userdetail = dBresult1;
            return View(query1);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
