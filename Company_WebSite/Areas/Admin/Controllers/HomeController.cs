using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company_WebSite.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Company_WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
            
        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItem());
        }
    }
}
