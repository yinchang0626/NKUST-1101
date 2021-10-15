using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Camera : IEquatable<Camera>,IEqualityComparer<Camera>, IComparable<Camera>
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
        

        public bool Equals(Camera other)
        {
            return other.編號 == this.編號;
        }
        public override string ToString()
        {
            var r1 = base.ToString();
            return $"行政區 :{this.行政區} 編號 :{this.編號} 地點:{this.測照地點} 速限:{this.速限}";
        }
        public override int GetHashCode()
        {
            return int.Parse(this.編號);
        }

        public bool Equals(Camera x, Camera y)
        {
            return x.編號 == y.編號;
        }

        public int GetHashCode([DisallowNull] Camera obj)
        {
            return obj.GetHashCode();
        }

        public int CompareTo(Camera other)
        {
            return int.Parse(this.編號).CompareTo(int.Parse(other.編號));
        }
    }
}
