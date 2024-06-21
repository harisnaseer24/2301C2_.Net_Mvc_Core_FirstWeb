using Microsoft.AspNetCore.Mvc;

namespace _2301C2firstWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AllProducts()
        {
            TempData.Keep("pname");
            TempData.Keep("desc");
            TempData.Keep("price");
            return View();
        }

        //[HttpGet]
        public IActionResult Add()
        {
            return View("AddProduct");
        }
        [HttpPost]
        public IActionResult Add(string pname, string desc, string price)
        {
            if (pname !=string.Empty && desc != string.Empty && price != string.Empty)
            {

                // for passing data from same to action to same view
                //ViewData["pname"] = pname;
                //ViewData["price"] = price;
                //ViewData["desc"] = desc;


                //ViewBag.pname = pname;
                //ViewBag.price = price;
                //ViewBag.desc = desc;

                // for passing data from cross controller and cross view

                TempData["pname"] = pname;
                TempData["price"] = price;
                TempData["desc"] = desc;

            }
             //return View("AddProduct");

            return RedirectToAction("Privacy", "Home");

            //return Redirect("Home/Index");
        }
    }
}
