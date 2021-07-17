using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class WebpagesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public WebpagesController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public  async Task<IActionResult>  Index()
        {
            return View( await _context.Webpages.Where(c => c.IsDeleted == false).Include(c => c.Category).ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WebpagesCrudVm webpagesCrudVm)
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

            Webpages newblog = new Webpages
            {
                Image = webpagesCrudVm.Image,

                Link = webpagesCrudVm.Link,

                CategoryId=webpagesCrudVm.CategoryId,

                IsDeleted = false,
            };
            await _context.Webpages.AddAsync(newblog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Webpages blog = await _context.Webpages.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Webpages blog = await _context.Webpages.FindAsync(id);
            if (blog == null) return NotFound();

          
           
            _context.Webpages.Remove(blog);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}
