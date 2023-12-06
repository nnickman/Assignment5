using Microsoft.AspNetCore.Mvc;

namespace Assignment_5.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
