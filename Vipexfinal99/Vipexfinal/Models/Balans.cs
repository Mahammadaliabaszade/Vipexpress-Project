using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Balans
    {
        public int Id { get; set; }

        public int Amount { get; set; }

      

        public AppUser AppUser { get; set; }

        public string AppUserId { get; set; }

   
    }
}
