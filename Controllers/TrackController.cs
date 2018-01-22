using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace music.Controllers
{
    public class TrackController : Controller
    {
        private readonly MusicDbContext _context; 

        public TrackController(MusicDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Track.ToListAsync());
        }
    }
}