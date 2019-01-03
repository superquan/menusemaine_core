namespace MenuSemaine_Core.Library
{
    using LiteDB;
    using Microsoft.Extensions.Hosting;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;


    public class MSCDB
    {

        private string _DBPath { get; set; }
        public MSCDB(string dbPath)
        {
            this._DBPath = dbPath;

            //// Re-use mapper from global instance
            //var mapper = BsonMapper.Global;

            //// "Produts" and "Customer" are from other collections (not embedded document)
            //mapper.Entity<Order>()
            //    .DbRef(x => x.Customer, "customers")   // 1 to 1/0 reference
            //    .DbRef(x => x.Products, "products")    // 1 to Many reference
            //    .Field(x => x.ShippingAddress, "addr"); // Embedded sub document
        }

        public LiteDatabase DataBase(string webrootpath)
        {
            var filePath = Path.Combine(webrootpath, this._DBPath);
            return new LiteDatabase(filePath);
        }
    }
}
