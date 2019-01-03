namespace MenuSemaine_Core.ViewComponents
{
    using MenuSemaine_Core.Library;
    using MenuSemaine_Core.Models;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ListPlatsViewComponent : ViewComponent
    {

        internal readonly MSCDB _db;
        private readonly IHostingEnvironment _env;

        public ListPlatsViewComponent(MSCDB mscDB, IHostingEnvironment env)
        {
            this._db = mscDB;
            this._env = env;
        }

        public IViewComponentResult Invoke()
        {
            var allPlats = new List<Plat>();

            using (var db = _db.DataBase(this._env.WebRootPath))
            {
                var plats = db.GetCollection<Plat>("Plats");

                allPlats.AddRange(plats.FindAll());
            }

            return View(allPlats);
        }
    }
}
