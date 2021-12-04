using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Data;

namespace WebMvc.Controllers
{
    public class ActivityController : Controller
    {
        protected ApplicationDbContext _applicationDbContext { get; }

        public ActivityController(
            ApplicationDbContext applicationDbContext
            )
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {

            var datas=_applicationDbContext.Activities
                .ToList();


            return View(datas);
        }
    }
}
