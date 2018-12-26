using MenuSemaine.Content;
using MenuSemaine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuSemaine.Manager
{
    public static class PlatManager
    {
        public static List<Plat> GetFivePlats(List<Plat> platsToBeExclude = null)
        {
            Random rnd = new Random((int) DateTime.Now.Ticks & 0x0000FFFF);
            List<Plat> newPlats = Plats.AllPlats.OrderBy(item => rnd.Next()).ToList();
            List<Plat> res = (platsToBeExclude != null && platsToBeExclude.Count > 0) ?
                newPlats.Where(plat => platsToBeExclude.Any(pe => pe.ID == plat.ID)).Take(5).ToList():
                newPlats.Take(5).ToList();
            return res;

        }
    }
}