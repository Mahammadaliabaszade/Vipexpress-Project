﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Models
{
    public class Xeber
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public virtual Xeberdetal Xeberdetal { get; set; }
    }
}
