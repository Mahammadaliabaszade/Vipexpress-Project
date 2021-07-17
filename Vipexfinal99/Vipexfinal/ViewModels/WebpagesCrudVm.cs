using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.ViewModels
{
    public class WebpagesCrudVm
    {
        public string Image { get; set; }

        public string Link { get; set; }

        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
