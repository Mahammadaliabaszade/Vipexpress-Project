using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Controllers
{
    public class XidmetController : Controller
    {
        private readonly AppDbContext _context;
        public XidmetController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            XidmetVm xidmetVm = new XidmetVm
            {
                Xidmets = _context.Xidmets.ToList()
            };
            return View(xidmetVm);
        }
    }
}
