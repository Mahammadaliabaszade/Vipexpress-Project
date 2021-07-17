using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Controllers
{
    public class FaqController : Controller
    {

        private readonly AppDbContext _context;
        public FaqController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            FaqVm faqVm = new FaqVm
            {
                Faqs = _context.Faq.ToList()
            };
            return View(faqVm);
        }
    }
}
