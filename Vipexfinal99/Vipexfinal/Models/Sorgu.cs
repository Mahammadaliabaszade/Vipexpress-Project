using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Sorgu
    {

        public int Id { get; set; }
         
        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }

     
        public string Title { get; set; }

        public string Description { get; set; }

         public string Link { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime Sendtime { get; set; }



    }
}
