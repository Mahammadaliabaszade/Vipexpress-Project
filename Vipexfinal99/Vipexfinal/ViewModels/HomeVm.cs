using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.Models;

namespace Vipexfinal.ViewModels
{
    public class HomeVm
    {
        public Mainphoto Mainphoto { get; set; }

        public Calculator Calculator { get; set; }

        public List<Advantages> Advantages { get; set; }
        public List<Xidmet> Xidmets { get; set; }

        public List<Working> Workings { get; set; }


        public List<Numunes> Numunes { get; set; }

        public List<Furset> Fursets { get; set; }



    }
}
