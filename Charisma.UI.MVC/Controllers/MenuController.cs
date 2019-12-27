using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charisma.Data.Data;
using Charisma.Data.InMemory;
using Charisma.UI.MVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Charisma.UI.MVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly ICharismaData db;

        public MenuController()
        {
            this.db = new MenuItemData();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}
