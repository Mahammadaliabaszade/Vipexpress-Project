using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.Models;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FaqController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public FaqController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public  IActionResult Index()
        {
            return View(_context.Faq.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FaqCrudVm webpagesCrudVm)
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

            Faq newblog = new Faq
            {
                Answer = webpagesCrudVm.Answer,

                Question = webpagesCrudVm.Question,

              
            };
            await _context.Faq.AddAsync(newblog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Faq blog = await _context.Faq.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Faq blog = await _context.Faq.FindAsync(id);
            if (blog == null) return NotFound();



            _context.Faq.Remove(blog);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}
