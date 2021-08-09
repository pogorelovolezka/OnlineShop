using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Domain;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.PageItems.GetPageItemByCodeWord("PageIndex"));
        }

        public IActionResult Contact()
        {
            return View(dataManager.PageItems.GetPageItemByCodeWord("PageContacts"));
        }
    }
}
