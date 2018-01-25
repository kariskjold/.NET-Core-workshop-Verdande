using Microsoft.AspNetCore.Mvc;
using music.Models;
using System;

namespace music.Controllers
{
    public class TrackController : Controller
    {
        public IActionResult Detail(int id)
        {
            var track = new SampleTracks().GetTrackById(id);

            Console.Write("Hello from deta");

            return View(track);
        }
        public IActionResult Index()
        {
            return View(new Track());
        }
    }
}