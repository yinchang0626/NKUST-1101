using System.Collections.Generic;
using WebMvc.Models;

namespace WebMvc.Services
{
    public interface IMenuItemServices
    {
        List<MenuItem> BuildToTree(List<MenuItem> menus);
        void ImportDataFromFile();
        List<MenuItem> ListTree();
        void TraverseTree(MenuItem parent, List<MenuItem> children);
    }
}