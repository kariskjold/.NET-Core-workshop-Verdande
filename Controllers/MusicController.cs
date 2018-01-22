using Microsoft.AspNetCore.Mvc;
using music.Models;

namespace music.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            var model = new PlaylistViewModel();
            model.Name = "Favorites";

            ViewData["Title"] = "My Music";
            return View(model);
        }
    }
}