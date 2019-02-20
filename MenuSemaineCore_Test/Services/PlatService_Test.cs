using MenuSemaine_Core.Library.Bin;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuSemaineCore_Test.Services
{

    public class PlatService_Test
    {
        public static IEnumerable<object[]> MemberDataObject
        {
            get
            {
                return new[] {
                    new object[] { "Yohoo" },
                    new object[] { 2 },
                    new object[] { new { Name = "Yohooo", Tag = "Miss, Yo, Ba" } },
                    new object[] { null }
                };
            }
        }

        [Fact]
        public void InsertPlat_Test()
        {

            var ps = new PlatServices();

            var plat = new { Name = "Yohooo", Tag = "Miss, Yo, Ba" };

            Assert.True(ps.InsertPlat(plat));

            plat = null;

            Assert.False(ps.InsertPlat(plat));

        }

        [Theory]
        //[InlineData(2)]
        [MemberData(nameof(MemberDataObject))]
        public void InsertPlat_Test2(object plat)
        {
            var ps = new PlatServices();

            if (plat != null)
            {
                Assert.True(ps.InsertPlat(plat));
            }
            else
            {
                Assert.False(ps.InsertPlat(plat));
                //Assert.True(ps.InsertPlat(plat));
            }



        }
    }
}
