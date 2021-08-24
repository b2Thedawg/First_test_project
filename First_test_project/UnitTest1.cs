using System;
using Xunit;

namespace First_test_project
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int bignumber = 1000;
            int biggernumber = bignumber + 1;

            Assert.True(bignumber < biggernumber);
        }

        public void Test2()
        {
            string köpaAlkohol;
            int ålder = 31;

            if (ålder > 18)
            {
                köpaAlkohol = "Öl";
            }
            else
            {
                köpaAlkohol = "Coca-cola";
            }

            Assert.Equal("Beer", köpaAlkohol);
        }
    }
}
