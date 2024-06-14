using _2301C2firstWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2301C2firstWeb.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
           public IActionResult Privacy()
        
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
      
      
    }
}