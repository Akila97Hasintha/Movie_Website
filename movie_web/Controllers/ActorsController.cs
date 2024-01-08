using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_web.Controllers
{
    public class ActorsController : Controller
    {
        private readonly MovieDbContext _context;

        public ActorsController(MovieDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _context.Actors.ToListAsync();
            return View(actors);
        }

    }
}
