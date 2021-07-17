using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.Models;

namespace Vipexfinal.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SifarisController : Controller
    {
        private readonly AppDbContext _context;
        public SifarisController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           List<Sifaris> appUser = _context.Sifaris.Include(u =>u.AppUser).ToList();
            return View(appUser);
        }
        public async Task<IActionResult> Tesdiqle(int? id)
        {
            if (id == null) return NotFound();
            Sifaris category = await _context.Sifaris.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Tesdiqle(int? id, Sifaris category)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return View(category);
            Sifaris isExist2 = await _context.Sifaris.FirstOrDefaultAsync(c => c.Id == category.Id);
            if (isExist2 == null) return NotFound();


            isExist2.StatusId = category.StatusId;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

    }
}
