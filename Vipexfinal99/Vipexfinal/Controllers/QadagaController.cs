using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Controllers
{
    public class QadagaController : Controller
    {

        private readonly AppDbContext _context;
        public QadagaController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            QadagaVm qadaga = new QadagaVm
            {
                    Qadaga=_context.Qadaga.FirstOrDefault()
            };

            return View(qadaga);
        }
    }
}
