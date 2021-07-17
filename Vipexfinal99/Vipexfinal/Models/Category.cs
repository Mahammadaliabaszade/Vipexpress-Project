using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        public List<Webpages> Webpages { get; set; }
    }
}
