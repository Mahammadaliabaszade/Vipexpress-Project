using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.DAL;
using Vipexfinal.Models;
using Vipexfinal.ViewModels;

namespace Vipexfinal.Controllers
{
    public class HesabController : Controller
    {
        private readonly AppDbContext _context;
        public HesabController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).FirstOrDefault();

            return View(appUser);
        }

        public  IActionResult Sifaristabl()
        {

            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u=>u.Sifarisler).ThenInclude(u=>u.Status).FirstOrDefault();
                
            return View(appUser);
        }

        public IActionResult Gozleyenler()
        {

            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Sifarisler).ThenInclude(u => u.Status).FirstOrDefault();

            return View(appUser);
        }

        public async Task<IActionResult> Fursetler()
        {
            HomeVm homeV = new HomeVm
            {
                Fursets = await _context.Furset.ToListAsync()
            };
             
            return View(homeV);
        }

        public IActionResult Sorgular()
        {
            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Sorgu).FirstOrDefault();

            return View();
          
        }

        public IActionResult Sorgularlist()
        {
            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Sorgu).FirstOrDefault();
            return View(appUser);
        }
        
 public IActionResult Sorgucreate(string Link,string Description,string Title,DateTime sendtime)
        {
            string username = User.Identity.Name;
            var result = _context.Users.FirstOrDefault(u => u.UserName == username);
            Sorgu sorgu = new Sorgu
            {
                Link = Link,
                Description = Description,
                Title = Title,
                AppUserId = result.Id,
                Sendtime=sendtime
                
            };
            _context.Sorgu.AddAsync(sorgu);
            _context.SaveChanges();
            return RedirectToAction("Sorgularlist", "Hesab");
           
        }

        public IActionResult Odenis()
        {
            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Balans).FirstOrDefault();
            return View(appUser);

          
        }
      
        public IActionResult Odenis2(AppUser balanss)
        {
            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Balans).FirstOrDefault();

            Balans oldbalans = _context.Balans.FirstOrDefault(u => u.AppUserId == result.Id);
            if (oldbalans != null)
            {
                oldbalans.Amount -= balanss.Balans.Amount;
                _context.Balans.Update(oldbalans);

            }
            else
            {
                Balans balans = new Balans
                {
                    Amount = balanss.Balans.Amount,
                    AppUserId = result.Id

                };
                _context.Balans.Add(balans);
            }



            _context.SaveChanges();
            return RedirectToAction("Index", "Hesab");



        }
        public IActionResult Balansartir()
        {

            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Balans).FirstOrDefault();
            return View(appUser);

           
        }

        public IActionResult Balansartir2(AppUser balanss)
        {
            string username = User.Identity.Name;
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Balans).FirstOrDefault();
           
            Balans oldbalans =  _context.Balans.FirstOrDefault(u => u.AppUserId == result.Id);
            if (oldbalans!=null)
            {
                oldbalans.Amount += balanss.Balans.Amount;
                _context.Balans.Update(oldbalans);
               
            }
            else
            {
                Balans balans = new Balans
                {
                    Amount = balanss.Balans.Amount,
                    AppUserId = result.Id

                };
                _context.Balans.Add(balans);
            }
            
            
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Hesab");



        }









    }
}
