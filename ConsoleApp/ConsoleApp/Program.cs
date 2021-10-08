using ConsoleApp.Utils;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullFileName = FilePath.GetFullPath("高雄市交通取締.csv");

            var csvService = new ConsoleApp.Services.ImportCsvService();
            var csvDatas = csvService.LoadFormFile(fullFileName);

            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", csvDatas.Count));

            var groupDatas = csvDatas.GroupBy(x => x.行政區, y => y).ToList();

            groupDatas.ForEach(x =>
            {
                var items = x.ToList();
                Console.WriteLine($"行政區 :{x.Key} 數量:{x.ToList().Count}");
                items.ForEach(x =>
                {
                    Console.WriteLine($"行政區 :{x.行政區} 編號 :{x.編號} 地點:{x.測照地點} 速限:{x.速限}");
                });
            });

            //csvDatas.ForEach(x =>
            //{
            //    Console.WriteLine($"編號 :{x.編號} 地點:{x.測照地點} 速限:{x.速限}");
            //});

            Console.ReadKey();


        }
    }
}
