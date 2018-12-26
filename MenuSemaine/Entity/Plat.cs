using MenuSemaine.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuSemaine.Entity
{
    public class Plat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public TypePlat Type { get; set; }
    }
}