using MenuSemaine_Core.Library.Bin;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuSemaineCore_Test.Services
{
    
    public class PlatServices_Test
    {
        [Fact]
        public void InsertPlat_Test()
        {
            var ps = new PlatServices();

            var platObj = new { Name="Yohoplat", Number = 9 };

            Assert.True(ps.InsertPlat(platObj));

            platObj = null;

            Assert.False(ps.InsertPlat(platObj));
            
        } 

    }
}
