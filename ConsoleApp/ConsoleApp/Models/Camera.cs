using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Camera
    {
        public string 編號 { get; set; }
        public string 型式 { get; set; }
        public string 測照地點 { get; set; }
        public string 測照方向 { get; set; }
        public string 速限 { get; set; }
        public string 行政區 { get; set; }
        public string 測照型式 { get; set; }


        public Dictionary<string, string> Datas { get; set; }


        public Camera()
        {

            this.Datas = new Dictionary<string, string>();
        }
    }
}
