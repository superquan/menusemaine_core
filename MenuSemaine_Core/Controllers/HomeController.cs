using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MenuSemaine_Core.Models;
using MenuSemaine_Core.Library;
using Microsoft.AspNetCore.Hosting;

namespace MenuSemaine_Core.Controllers
{
    public class HomeController : Controller
    {
        internal readonly MSCDB _db;
        private readonly IHostingEnvironment _env;

        public HomeController(MSCDB mscDB, IHostingEnvironment env)
        {
            this._db = mscDB;
            this._env = env;
        }

        public IActionResult Index()
        {
            var allPlats = new List<Plat>();
            
            using (var db = _db.DataBase(this._env.WebRootPath))
            {
                var plats = db.GetCollection<Plat>("Plats");

                allPlats.AddRange(plats.FindAll());
            }

            return View(allPlats);
        }

        public IActionResult InsertPlat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertPlat([Bind("Name,Type")] Plat plat)
        {
            using (var db = _db.DataBase(this._env.WebRootPath))
            {
                var plats = db.GetCollection<Plat>("Plats");
                plats.Insert(new Plat { ID = Guid.NewGuid().ToString(), Name = plat.Name, Type = plat.Type});
            }

            return ViewComponent("ListPlats");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
