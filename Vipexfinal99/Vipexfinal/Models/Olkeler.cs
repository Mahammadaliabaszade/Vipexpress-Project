using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Olkeler
    {
        public int Id { get; set; }

        public string Name { get; set; }
         
        public Sifaris Sifaris { get; set; }

        public int SifarisId { get; set; }
    }
}
