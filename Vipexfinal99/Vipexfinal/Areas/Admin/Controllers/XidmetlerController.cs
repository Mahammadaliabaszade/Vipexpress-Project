using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.Extentions;
using Vipexfinal.Models;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class XidmetlerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public XidmetlerController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Xidmets.Where(c=>c.IsDeleted==false).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(XidmetCrudVm xidmetvm)
        {

           

            //if (!ModelState.IsValid) return NotFound();
            //if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            //{
            //    return View();
            //}

            //if (!xidmetvm.Photo.IsImage())
            //{
            //    ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
            //    return View();
            //}

            //if (xidmetvm.Photo.MaxLength(200))
            //{
            //    ModelState.AddModelError("Photo", "Shekilin olchusu max 200kb ola biler");
            //    return View();
            //}
            //string path = Path.Combine("storage", "news");
            //string fileName = await xidmetvm.Photo.SaveImg(_env.WebRootPath, path);

            Xidmet newblog = new Xidmet
            {
                Image = xidmetvm.Image,
             
                Title = xidmetvm.Title,
                
                IsDeleted = false,
            };
            await _context.Xidmets.AddAsync(newblog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Xidmet blog = await _context.Xidmets.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Xidmet blog = await _context.Xidmets.FindAsync(id);
            if (blog == null) return NotFound();

            //if (!Helper.DeleteImage(_env.WebRootPath, "img", slider.Image))
            //{
            //    ModelState.AddModelError("", "Some problem exist");
            //    return View(slider);
            //}
            _context.Xidmets.Remove(blog);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}
