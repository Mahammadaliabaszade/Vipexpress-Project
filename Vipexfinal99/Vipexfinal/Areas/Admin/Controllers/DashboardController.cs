using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;

namespace Vipexfinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        private readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
