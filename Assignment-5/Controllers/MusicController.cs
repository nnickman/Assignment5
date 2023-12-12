using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
