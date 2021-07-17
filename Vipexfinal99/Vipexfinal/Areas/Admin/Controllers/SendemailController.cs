using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;

namespace Vipexfinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SendemailController : Controller
    {
        private readonly AppDbContext _context;
        public SendemailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View( await _context.Elaqes.ToListAsync());
        }
    }
}
