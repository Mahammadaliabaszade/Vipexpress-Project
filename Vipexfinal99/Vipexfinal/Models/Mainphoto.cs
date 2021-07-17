using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Mainphoto
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
