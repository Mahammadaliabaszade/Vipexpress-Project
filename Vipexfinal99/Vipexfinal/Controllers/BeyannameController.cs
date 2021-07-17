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
    public class BeyannameController : Controller
    {
        private readonly AppDbContext _context;
        public BeyannameController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Beyanname(string Link,DateTime sendtime,string MagazaName,int Qiymet,string Ofisname,string Qeyd )
        {
            string username = User.Identity.Name;
            var result = _context.Users.FirstOrDefault(u => u.UserName == username);
            Beyanname beyanname = new Beyanname
            {
                Link=Link,
                SendTime=sendtime,
                MagazaName=MagazaName,
                Qiymet=Qiymet,
                OfisName=Ofisname,
                Qeyd=Qeyd,
                AppUserId = result.Id,
                StatusId = 1,
            };

            _context.Beyanname.AddAsync(beyanname);
            _context.SaveChanges();
            return RedirectToAction("Index", "Hesab");
        }
        public IActionResult Beyantabl()
        {

            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Beyannameler).ThenInclude(u => u.Status).FirstOrDefault();

            return View(appUser);
        }


    }
}
