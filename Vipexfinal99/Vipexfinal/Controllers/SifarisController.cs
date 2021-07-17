using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.Models;

namespace Vipexfinal.Controllers
{
    public class SifarisController : Controller
    {
      
        private readonly AppDbContext _context;
     
        public SifarisController(AppDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Sifaris(string Link,int ProductCount,int Qiymet,string Color,string OLcu,string Qeyd,DateTime sendtime)
        {
            string username = User.Identity.Name;
            var result =await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);

            //string username = User.Identity.Name;
            //var result = _context.Users.FirstOrDefault(u => u.UserName == username);
            //var result2 = _context.Sifaris.Where(u => u.AppUserId == result.Id).ToList();

            //string iduser = (string)TempData["ID"];

            Sifaris sifaris = new Sifaris
            {
                Link=Link,
                ProductCount=ProductCount,
                Qiymet=Qiymet,
                Color=Color,
                OLcu=OLcu,
                Qeyd=Qeyd,
                Daxilikuryer=false,
                AppUserId = result.Id,
                StatusId=1,
                Sendtime=sendtime,

            };

           await _context.Sifaris.AddAsync(sifaris);
           await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Hesab");
        
        }
    }
}
