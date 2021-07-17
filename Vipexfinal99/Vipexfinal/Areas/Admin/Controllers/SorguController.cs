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
    public class SorguController : Controller
    {
        private readonly AppDbContext _context;
        public SorguController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Sorgu.Where(s=>s.IsDeleted==false).Include(s=>s.AppUser).ToList());
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Sorgu category = await _context.Sorgu.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeletePost(int? id)
        {

            if (id == null) return NotFound();
            Sorgu category = await _context.Sorgu.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();

            category.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
