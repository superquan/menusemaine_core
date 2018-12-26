using MenuSemaine.Constants;
using MenuSemaine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuSemaine.Content
{
    public static class Plats
    {
        public static List<Plat> AllPlats
        {
            get
            {
                return new List<Plat> { 
                    new Plat { ID = 1, Name = "意大利面＋西红柿酱＋parmesan", Type = TypePlat.法餐},
                    new Plat { ID = 2, Name = "意大利奶油海鲜面", Type = TypePlat.法餐},
                    new Plat { ID = 3, Name = "Quiche lorraine - Lardon+PDT", Type = TypePlat.法餐},
                    new Plat { ID = 4, Name = "煎鸡排（提前腌好）＋蒸西兰花", Type = TypePlat.法餐},
                    new Plat { ID = 5, Name = "煎鸡排（提前腌好）＋素炒花菜", Type = TypePlat.法餐},
                    new Plat { ID = 6, Name = "Quiche lorraine - Jambon+Saumon+épinard", Type = TypePlat.法餐},
                    new Plat { ID = 7, Name = "煎牛排＋炒豆角", Type = TypePlat.法餐},
                    new Plat { ID = 8, Name = "鸡蛋青菜有白发面", Type = TypePlat.粉面},
                    new Plat { ID = 9, Name = "鸡蛋青菜方便面", Type = TypePlat.粉面},
                    new Plat { ID = 10, Name = "急冻蔬菜炒意面", Type = TypePlat.粉面},
                    new Plat { ID = 11, Name = "急冻蔬菜炒中国面", Type = TypePlat.粉面},
                    new Plat { ID = 12, Name = "螺狮粉", Type = TypePlat.粉面},
                    new Plat { ID = 13, Name = "牛肉粉", Type = TypePlat.粉面},
                    new Plat { ID = 14, Name = "榨菜肉丝米粉", Type = TypePlat.粉面},
                    new Plat { ID = 15, Name = "火腿鸡蛋青菜炒饭", Type = TypePlat.饭},
                    new Plat { ID = 16, Name = "葱花蛋炒饭", Type = TypePlat.饭},
                    new Plat { ID = 17, Name = "水煮鱼", Type = TypePlat.饭},
                    new Plat { ID = 18, Name = "卤牛肉＋素炒青菜", Type = TypePlat.饭},
                    new Plat { ID = 19, Name = "牛肉炖土豆＋素炒青菜", Type = TypePlat.饭},
                    new Plat { ID = 20, Name = "西红柿炒蛋＋素炒courgette", Type = TypePlat.饭},
                    new Plat { ID = 21, Name = "地三鲜（茄子土豆青椒）＋炒鱼片", Type = TypePlat.饭},
                    new Plat { ID = 22, Name = "宫保鸡丁＋素炒白菜", Type = TypePlat.饭},
                    new Plat { ID = 23, Name = "canelle炖肉＋素炒白菜", Type = TypePlat.饭},
                    new Plat { ID = 24, Name = "玉米炒碎肉＋蘑菇鸡蛋", Type = TypePlat.饭},
                    new Plat { ID = 25, Name = "排骨炖白萝卜＋蘑菇炒蛋", Type = TypePlat.饭},
                    new Plat { ID = 26, Name = "虾仁炒蛋＋素炒青菜", Type = TypePlat.饭},
                    new Plat { ID = 27, Name = "素炒南瓜＋芹菜肉丝", Type = TypePlat.饭},
                    new Plat { ID = 28, Name = "西兰花炒虾仁＋蘑菇炒肉片", Type = TypePlat.饭},
                    new Plat { ID = 29, Name = "烤鸡腿＋素炒花菜", Type = TypePlat.饭},
                    new Plat { ID = 30, Name = "羊肉炖胡萝卜＋素炒西兰花", Type = TypePlat.饭},
                    new Plat { ID = 31, Name = "红烧排骨＋素炒白菜", Type = TypePlat.饭},
                    new Plat { ID = 32, Name = "红烧鱼块＋葱花炒蛋", Type = TypePlat.饭},
                    new Plat { ID = 33, Name = "炒鱼片＋蘑菇炒蛋", Type = TypePlat.饭},
                    new Plat { ID = 34, Name = "土豆丝＋芹菜肉片", Type = TypePlat.饭}
                };
            }
        }
    }
}