using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Controllers
{
    public class WebpagesController : Controller
    {
        private readonly AppDbContext _context;
        public WebpagesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            WebpagesVm webpages = new WebpagesVm
            {
              Webpages=_context.Webpages.Where(c=>c.IsDeleted==false).Include(c=>c.Category).ToList(),
              Categories=_context.Categories.Where(d=>d.IsDeleted==false).ToList()

            };
            return View(webpages);
        }
    }
}
