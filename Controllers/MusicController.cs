using Microsoft.AspNetCore.Mvc;

namespace music.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "My Music";
            return View();
        }
    }
}