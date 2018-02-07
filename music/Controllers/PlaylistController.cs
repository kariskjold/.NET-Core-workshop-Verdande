using Microsoft.AspNetCore.Mvc;
using music.Models;
using System.Collections.Generic;
using System.Linq;


namespace music.Controllers
{
    public class PlaylistController : Controller
    {
        private List<Track> tracks;

        public PlaylistController()
        {
            tracks = new SampleTracks().GetAllTracks();
        }   

        public IActionResult Index()
        {
            var model = new PlaylistViewModel
            {
                Name = "Favorites",
                Tracks = tracks
            };

            ViewData["Title"] = "Playlist";
            return View(model);
        }

        public IActionResult Grid()
        {
            var model = new PlaylistViewModel
            {
                Name = "Favorites",
                Tracks = tracks
            };

            ViewData["Title"] = "Playlist";
            return View(model);
        }

        public IActionResult TopTen(){

            var top10 = tracks.OrderBy(x => x.NumPlays).Reverse().Take(10).ToList();

            var model = new PlaylistViewModel
            {
                Name = "Top 10",
                Tracks = top10
            };

            ViewData["Title"] = "Playlist";
            return View(model);
        }
    }
}