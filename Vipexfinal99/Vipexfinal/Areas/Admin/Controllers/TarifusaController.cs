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
    public class TarifusaController : Controller
    {

        private readonly AppDbContext _context;
        public TarifusaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
           
            return View( await _context.Tarifusas.ToListAsync());
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Tarifusa tarifusa = await _context.Tarifusas.FirstOrDefaultAsync(c => c.Id == id);
            if (tarifusa == null) return NotFound();
            return View(tarifusa);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Tarifusa tarifusa)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return View(tarifusa);
            Tarifusa isExist2 = await _context.Tarifusas.FirstOrDefaultAsync(c => c.Id == tarifusa.Id);
            if (isExist2 == null) return NotFound();

           
            isExist2.Qiymet = tarifusa.Qiymet;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
    }
}
