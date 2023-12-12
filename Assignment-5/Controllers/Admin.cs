using Microsoft.AspNetCore.Mvc;

namespace Assignment_5.Controllers
{
    public class Admin : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
