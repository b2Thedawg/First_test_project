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
            string k�paAlkohol;
            int �lder = 31;

            if (�lder > 18)
            {
                k�paAlkohol = "�l";
            }
            else
            {
                k�paAlkohol = "Coca-cola";
            }

            Assert.Equal("Beer", k�paAlkohol);
        }
    }
}
