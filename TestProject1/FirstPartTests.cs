using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ConsoleApp1.TestProject1
{
    public class FirstPartTests
    {
        [Fact]
        public void TestMethod1()
        {
            double[] myArray = { 1.0000, 0.001, 2.000, 0.03, -3.20003 };
            FirstPart myArr = new FirstPart(myArray);
            Assert.Equal(-3.20003, myArr.GetMinimumElement());

        }

        [Fact]
        public void TestMethod2()
        {
            double[] myArray = { -2.245, 1.00, 0.001, 2.000, 0.03, -3.20003, 3.549, -1.034 };
            FirstPart myArr = new FirstPart(myArray);
            Assert.Equal(-1.1690300000000002, myArr.GetSumBetweenPositiveElements());

        }

        [Fact]
        public void TestMethod3()
        {
            double[] myArray = { -2.245, 0.001, 2.000, 0.03, 3.549, -1.034 };
            double[] correctArr = { 0.001, 0.03, 2.000, - 2.245, 3.549, -1.034 };
            FirstPart myArr = new FirstPart(myArray);
            Assert.Equal(correctArr, myArr.SortByZeros());

        }


    }
}
