using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.Models;

namespace Vipexfinal.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
           
            return View();

          
        }

        public ActionResult Sendemail(string Name, string Shirket, string Epoct, int Number, string Message)
        {
            if (!ModelState.IsValid) return Content("Butun xanalari doldurmalisiniz");
            
           //_context.Sifaris.Where(x=>x.Appuserid==)
            Elaqe newelaqe = new Elaqe
            {
                Name = Name,
                Shirket = Shirket,
                Epoct = Epoct,
                Number = Number,
                Message = Message

            };
            _context.Elaqes.AddAsync(newelaqe);
            _context.SaveChanges();
            return RedirectToAction("Index", "Contact");

            
        }



    }
}
