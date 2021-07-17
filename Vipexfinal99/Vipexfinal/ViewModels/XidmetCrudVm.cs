using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.ViewModels
{
    public class XidmetCrudVm
    {
        public string Image { get; set; }
       
        public string Title { get; set; }

       

        public bool IsDeleted { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
