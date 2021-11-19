using ConsoleApp.Services;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonService = new ImportJsonService();
            DataService dataService = new DataService();

            var jsonDatas = jsonService.LoadFormFile(Utils.FilePath.GetFullPath("高雄活動.txt"));

            jsonDatas.ForEach(i =>
            {
                dataService.Insert(i);
            });


            
            var rows=dataService.GetActivities();

            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", rows.Count));
            rows.ForEach(x =>
            {
                Console.WriteLine(string.Format("編號 :{0} 名稱:{1} 地點:{2}", x.PrgId, x.PrgName, x.OrgName));
            });

            Console.ReadKey();

            //var csvService1 = new ImportCsvService();

            //var csvDatas = csvService1.LoadFormFile(Utils.FilePath.GetFullPath("高雄市交通取締.csv"));

            //Console.WriteLine(string.Format("分析完成，共有{0}筆資料", csvDatas.Count));
            //csvDatas.ForEach(x =>
            //{
            //    Console.WriteLine($"編號 :{x.編號} 地點:{x.測照地點} 速限:{x.速限}");
            //});
            //Console.ReadKey();

            //var xmlService1 = new ImportXmlService();

            //var datas = xmlService1.LoadFormFile(Utils.FilePath.GetFullPath("北捷站點.xml"));

            //Console.WriteLine(string.Format("分析完成，共有{0}筆資料", datas.Count));
            //datas.ForEach(x =>
            //{
            //    Console.WriteLine(string.Format("編號 :{0} 名稱:{1}({2}) 描述:{3}", x.StationID, x.StationName, x.ExitName, x.LocationDescription));
            //});

            //Console.ReadKey();

            //var jsonService = new ImportJsonService();

            //var jsonDatas = jsonService.LoadFormFile(Utils.FilePath.GetFullPath("高雄活動.txt"));

            //Console.WriteLine(string.Format("分析完成，共有{0}筆資料", jsonDatas.Count));
            //jsonDatas.ForEach(x =>
            //{
            //    Console.WriteLine(string.Format("編號 :{0} 名稱:{1} 地點:{2}", x.PrgId, x.PrgName, x.OrgName));
            //});

            //Console.ReadKey();

        }
    }
}
