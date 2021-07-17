using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Xeberdetal
    {

        public int Id { get; set; }
        public string Imaged { get; set; }

        public bool IsDeleted { get; set; }

        public string Maintitle { get; set; }

        public string Image2 { get; set; }
        public string Title2 { get; set; }
        public string Image3{ get; set; }
        public string Title3 { get; set; }
        public string Image4 { get; set; }
        public string Title4 { get; set; }

        public string Image5 { get; set; }
        public string Title5 { get; set; }

        public int XeberId { get; set; }

        public Xeber Xeber { get; set; }

    }
}
