using MenuSemaine_Core.Library.Bin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuSemaine_Test.DotNetCore.Services
{
    [TestClass]
    public class PlatServices_Test
    {
        [TestMethod]
        public void InsertPlat_Test()
        {
            var ps = new PlatServices();

            var platObj = new { Name="Yohoplat", Number = 9 };

            Assert.IsTrue(ps.InsertPlat(platObj));

            platObj = null;

            Assert.IsFalse(ps.InsertPlat(platObj));
            
        } 
    }
}
