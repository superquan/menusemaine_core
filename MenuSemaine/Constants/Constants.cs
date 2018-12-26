using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuSemaine.Constants
{
    public static class Constants
    {
        public static Dictionary<int, string> Weeks = new Dictionary<int, string>()
        {
            {1, "星期一"}, 
            {2, "星期二"}, 
            {3, "星期三"}, 
            {4, "星期四"}, 
            {5, "星期五"}
        };
    }
}