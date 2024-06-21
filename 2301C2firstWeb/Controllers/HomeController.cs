using _2301C2firstWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2301C2firstWeb.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            TempData.Keep("pname");
            TempData.Keep("desc");
            TempData.Keep("price");
            return View();
        }
           public IActionResult Privacy()
        
        {
            TempData.Keep("pname");
            TempData.Keep("desc");
            TempData.Keep("price");
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
      
      
    }
}