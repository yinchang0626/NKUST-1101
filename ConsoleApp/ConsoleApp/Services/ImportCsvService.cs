using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public class ImportCsvService
    {
        public List<Camera> LoadFormFile(string filePath)
        {
            var lines = System.IO.File.ReadAllLines(filePath);

            var cameras= lines.ToList().Skip(1).Select(x =>
            {
                var columns = x.Split(',');
                var item = new Camera()
                {
                    編號=columns[0],
                    型式 = columns[1],
                    測照地點 = columns[2],
                    測照方向 = columns[3],
                    速限 = columns[4],
                    行政區 = columns[5],
                    測照型式 = columns[6],
                    座標緯度 = columns[7],
                    座標經度 = columns[8],
                };
                return item;
            });
            return cameras.ToList();
            //return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Activity>>(str);
        }
    }
}
