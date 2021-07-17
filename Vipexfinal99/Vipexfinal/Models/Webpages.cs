using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Webpages
    {

        public int Id { get; set; }

        public string Image { get; set; }

        public string Link { get; set; }

        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }

        public  virtual Category Category { get; set; }
    }
}
