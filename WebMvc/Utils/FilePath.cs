using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMvc.Utils
{
    public static class FilePath
    {
        public static string GetFullPath(string fileName)
        {
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Files",fileName);
        }
    }
}
