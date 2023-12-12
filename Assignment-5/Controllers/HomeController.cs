using Assignment_5.Data;
using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Assignment_5Context _context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = _context;
        }

        public async Task<IActionResult> Index(string genre, string artist)
        {
            if(_context == null)
            {
                return Problem("Assignment5Context.Songs is null");
            }
            var allSongs = from x in _context.Song
                               select x;

            var songs = from x in _context.Song
                            select x;

                string thisArtist = (from x in _context.Artist
                                     where x.Name == artist
                                     select x.Id).ToString();

            
            int thisArtistId;
            Int32.TryParse(thisArtist, out thisArtistId);
            

            List<string> artistList = new List<string>();

            if(!String.IsNullOrEmpty(genre)) 
            {
                songs = songs.Where(s => s.ArtistID == thisArtistId);
            }
            }
        }








        public IActionResult Index()
        {
            return View();
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