using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Mesaj
    {
        public int Id { get; set; }

        public DateTime Createtime { get; set; }

        public string Title { get; set; }

        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }


    }
}
