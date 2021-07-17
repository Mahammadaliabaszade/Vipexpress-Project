using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Elaqe
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        public string Shirket { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        public string Epoct { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        public int Number { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        public string Message { get; set; }
      
    }
}
