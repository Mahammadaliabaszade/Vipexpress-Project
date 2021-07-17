using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.Models;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           
    
          
            
                HomeVm homeVm = new HomeVm
                {
                    Mainphoto = _context.Mainphoto.FirstOrDefault(),
                    Calculator = _context.Calculator.FirstOrDefault(),
                    Advantages = _context.Advantages.ToList(),
                    Xidmets = _context.Xidmets.Take(3).ToList(),
                    Workings = _context.Working.Take(4).ToList(),
                    Numunes = _context.Numunes.ToList()

                };
                return View(homeVm);
         
            
           
        }

      
    }
}
