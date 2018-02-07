using Microsoft.AspNetCore.Mvc;
using music.Models;
using System;

namespace music.Controllers
{
    public class TrackController : Controller
    {
        public IActionResult Index(int id)
        {
            var track = new SampleTracks().GetTrackById(id);
            return View(track);
        }
    }
}