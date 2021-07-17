using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Vipexfinal.Helpers
{
    public static class Helper
    {
        public static void DeleteImage(string root, string folder, string fileName)
        {
            string filePath = Path.Combine(root, folder, fileName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }
    }


    public enum Roles
    {
        Admin,
        Member
    }
}
