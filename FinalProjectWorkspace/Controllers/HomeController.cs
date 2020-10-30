using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProjectWorkspace.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // Views Employee Home After Login
        public IActionResult EmployeeHomeView()
        {
            return View();
        }

        // Views Manager Home After Login
        public IActionResult ManagerHomeView()
        {
            return View();
        }


        // Views Order Confirmed
        public IActionResult OrderConfirmed()
        {
            return View();
        }


        // Views Cancelled Order Confirmed
        public IActionResult CancelledOrderConfirmed()
        {
            return View();
        }
    }
}
