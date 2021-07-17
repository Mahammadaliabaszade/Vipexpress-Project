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
    public class BeyannameController : Controller
    {
        private readonly AppDbContext _context;
        public BeyannameController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Beyanname> appUser = _context.Beyanname.Include(u => u.AppUser).ToList();
            return View(appUser);
        }
        public async Task<IActionResult> Tesdiqle(int? id)
        {
            if (id == null) return NotFound();
            Beyanname category = await _context.Beyanname.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Tesdiqle(int? id, Beyanname category)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return View(category);
            Beyanname isExist2 = await _context.Beyanname.FirstOrDefaultAsync(c => c.Id == category.Id);
            if (isExist2 == null) return NotFound();


            isExist2.StatusId = category.StatusId;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

    }
}
