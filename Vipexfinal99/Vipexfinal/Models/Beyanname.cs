using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Beyanname
    {
        public int Id { get; set; }

        public DateTime SendTime { get; set; }
        public string Link { get; set; }

       

        public virtual AppUser AppUser { get; set; }

        public string AppUserId { get; set; }

        public string MagazaName { get; set; }

        public int Qiymet { get; set; }

        public string OfisName { get; set; }
        public string Qeyd { get; set; }

        public Status Status { get; set; }
        public int StatusId { get; set; }


    }
}
