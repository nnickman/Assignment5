using Assignment_5.Data;
using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Assignment_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Assignment_5Context _context;

        public HomeController(ILogger<HomeController> logger, Assignment_5Context context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(string genre, string artist)
        {
            if(_context == null)
            {
                return Problem("'Assignment5Context.Songs' is null");
            }

            var allSongs = from x in _context.Media
                           select x;
            var songs = from x in _context.Media 
                        select x;

            List<string> artistList = new List<string>();


            if (!String.IsNullOrEmpty(genre))
            {
                songs = songs.Where(x => x.Genre == genre);
                foreach (var song in songs)
                {
                    if (!artistList.Contains(song.Artist))
                    {
                        artistList.Add(song.Artist);
                    }
                }
            }

                if (!String.IsNullOrEmpty(artist))
                {
                    songs = songs.Where(x => x.Artist == artist);
                }

                var songList = songs.ToList();
                var allSongsList = allSongs.ToList();
                var genreList = new List<string>();
                foreach (var song in allSongsList)
                {
                    if(!genreList.Contains(song.Genre))
                        genreList.Add(song.Genre);
                }

                
                ViewData["Genres"] = genreList;
                ViewData["Artists"] = artistList;
                ViewData["Songs"] = songList;


            return View(await songs.ToListAsync());

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