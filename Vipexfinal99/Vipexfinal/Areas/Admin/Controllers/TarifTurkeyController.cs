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
    public class TarifTurkeyController : Controller
    {
        private readonly AppDbContext _context;
        public TarifTurkeyController(AppDbContext context)
        {
            _context = context;
        }
     

        public async Task<IActionResult> Index()
        {

            return View(await _context.TarifTurkeys.ToListAsync());
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            TarifTurkey tarifusa = await _context.TarifTurkeys.FirstOrDefaultAsync(c => c.Id == id);
            if (tarifusa == null) return NotFound();
            return View(tarifusa);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, TarifTurkey tarifusa)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return View(tarifusa);
            TarifTurkey isExist2 = await _context.TarifTurkeys.FirstOrDefaultAsync(c => c.Id == tarifusa.Id);
            if (isExist2 == null) return NotFound();


            isExist2.Qiymet = tarifusa.Qiymet;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }


    }
}
