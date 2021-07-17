using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class AppUser:IdentityUser
    {


        public string FullName { get; set; }

        public int Password { get; set; }

        public int MusteriKod { get; set; }
        public List<Sifaris> Sifarisler { get; set; }

        public Balans Balans { get; set; }

        public List<Beyanname> Beyannameler { get; set; }

        public List<Sorgu> Sorgu { get; set; }

        public List<Mesaj> Mesaj { get; set; }
    }
}
