using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Sifaris
    {
        public int Id { get; set; }
        public virtual AppUser AppUser { get; set; }

        public  string AppUserId { get; set; }
        public string Link { get; set; }

        public string Color { get; set; }
        public string OLcu { get; set; }

        public int ProductCount { get; set; }

        public int Qiymet { get; set; }


        public string Qeyd { get; set; }

        public List<Olkeler> Olkeler { get; set; }

      
        public bool Daxilikuryer { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }
       
        public DateTime Sendtime { get; set; }

    }
}
