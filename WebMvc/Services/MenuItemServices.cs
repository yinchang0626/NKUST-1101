using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.Services
{
    public class MenuItemServices
    {

        public void ImportDataFromFile(WebMvc.Data.ApplicationDbContext applicationDbContext)
        {
            var filePath = Utils.FilePath.GetFullPath("MenuItems.json");

            var jsonString = System.IO.File.ReadAllText(filePath);

            var menus = System.Text.Json.JsonSerializer.Deserialize<List<MenuItem>>(jsonString);

            //var menuList = Flatten(menus).ToList();

            menus.ForEach(m =>
            {
                m.Code = (menus.IndexOf(m) + 1).ToString().PadLeft(4, '0');
            });

            TraverseTree(null, menus);

            applicationDbContext.MenuItems.AddRange(menus);
            applicationDbContext.SaveChanges();
        }

        public static IEnumerable<MenuItem> Flatten(IEnumerable<MenuItem> item)
        {
            return item.SelectMany(c => Flatten(c.Children??new List<MenuItem>())).Concat(item);
        }

        public void TraverseTree(MenuItem parent, List<MenuItem> children)
        {
            if (children == null || !children.Any())
                return;

            foreach (var c in children)
            {
                c.Parent = parent;

                c.Code = parent?.Code == null ?
                    (children.IndexOf(c) + 1).ToString().PadLeft(4, '0') :
                    parent.Code + "." + (children.IndexOf(c) + 1).ToString().PadLeft(4, '0');

                var safeChildren = c.Children?.ToList() ?? new List<MenuItem>();

                TraverseTree(c, safeChildren);
            }
        }

        public void SetCode()
        {

        }

        public List<MenuItem> Build(List<MenuItem> menus)
        {
            List<MenuItem> roots = new List<MenuItem>();

            menus.OrderBy(x => x.Code).ToList().ForEach(x =>
              {
                  if (!x.Code.Contains("."))
                      roots.Add(x);

              });
            return null;
        }

        
    }
}
