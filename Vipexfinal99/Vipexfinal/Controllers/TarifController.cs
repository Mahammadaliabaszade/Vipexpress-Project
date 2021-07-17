using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Controllers
{
    public class TarifController : Controller
    {
        private readonly AppDbContext _context;
        public TarifController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TarifturkeyVm tarifturkey = new TarifturkeyVm
            {
                TarifTurkeys = _context.TarifTurkeys.ToList(),
                Tarifusas=_context.Tarifusas.ToList()
            };
            return View(tarifturkey);
        }
    }
}
