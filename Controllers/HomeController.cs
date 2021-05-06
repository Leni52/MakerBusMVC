using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerBusMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Route()
        {
            return View();
        }

        public IActionResult Toys()
        {
            return View();
        }

        public IActionResult Timetable()
        {
            return View();
        }
    }
}
