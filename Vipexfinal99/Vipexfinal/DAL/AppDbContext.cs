using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.Models;

namespace Vipexfinal.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Mainphoto> Mainphoto { get; set; }

        public DbSet<Calculator> Calculator { get; set; }

        public DbSet<Advantages> Advantages { get; set; }

        public DbSet<Xidmet> Xidmets { get; set; }


        public DbSet<Working> Working { get; set; }

        public DbSet<Numunes> Numunes { get; set; }

        public DbSet<Bio> Bio { get; set; }


        public DbSet<Faq> Faq { get; set; }

        public DbSet<TarifTurkey> TarifTurkeys { get; set; }

        public DbSet<Tarifusa> Tarifusas{ get; set; }

        public DbSet<Qadaga> Qadaga { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Webpages> Webpages { get; set; }


        public DbSet<Xeber> Xebers { get; set; }

        public DbSet<Xeberdetal > Xeberdetals { get; set; }

        public DbSet<Elaqe> Elaqes { get; set; }

        public DbSet<Sifaris> Sifaris { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Olkeler> Olkeler { get; set; }

        public DbSet<Status> Status { get; set; }


        public DbSet<Furset> Furset { get; set; }

        public DbSet<Sorgu> Sorgu { get; set; }

        public DbSet<Beyanname> Beyanname { get; set; }

        public DbSet<Balans> Balans { get; set; }


    }
}
