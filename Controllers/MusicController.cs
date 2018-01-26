using Microsoft.AspNetCore.Mvc;
using music.Models;
using System.Collections.Generic;


namespace music.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            var model = new PlaylistViewModel
            {
                Name = "Favorites",
                Tracks = new SampleTracks().GetAllTracks()
            };

            ViewData["Title"] = "My Music";
            return View(model);
        }
        public IActionResult Grid()
        {
            var model = new PlaylistViewModel
            {
                Name = "Favorites",
                Tracks = new SampleTracks().GetAllTracks()
            };

            ViewData["Title"] = "My Music";
            return View(model);
        }
    }
}