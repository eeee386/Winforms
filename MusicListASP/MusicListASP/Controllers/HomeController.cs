using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicListASP.Context;
using MusicListASP.Models;
using System;
using System.Linq;

namespace MusicListASP.Controllers
{
    public class HomeController : Controller
    {

        private readonly EFContext _context = new EFContext();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Artist,PublishYear,MusicLength,Priority")] Music music)
        {
            Console.WriteLine("it is called: " + ModelState.IsValid);
                if (ModelState.IsValid)
                {
                    _context.Add(music);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(music);
         }


        public async Task<IActionResult> Index()
        {
                var musics = await _context.Music.ToListAsync();
                return View(musics.OrderBy(o => o.Priority).Reverse());
        }

    }
}
