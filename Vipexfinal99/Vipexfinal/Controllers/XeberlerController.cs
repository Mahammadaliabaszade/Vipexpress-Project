using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.Models;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Controllers
{
    public class XeberlerController : Controller
    {

        private readonly AppDbContext _context;
        public XeberlerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            XeberVm xeberVm = new XeberVm
            {
                Xebers=_context.Xebers.Where(c=>c.IsDeleted==false).Include(c=>c.Xeberdetal).ToList(),
                Xeberdetals=_context.Xeberdetals.Where(c=>c.IsDeleted==false).ToList()
                
            };
            return View(xeberVm);
        }

        public IActionResult Detail(int? id)
        {

            Xeber element = _context.Xebers.Where(x => x.Id == id).Include(c => c.Xeberdetal).FirstOrDefault();
              


            return View(element);
        }
    }
}
