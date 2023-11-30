using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TestProject1
{
    public class SecondPartTests
    {
        [Fact]
        public void TestMethod1()
        {
            int[,] myArray = { { -8, 0, -3 }, { 6, 4, 8 } };
            SecondPart myArr = new SecondPart(myArray);
        }

        //[Fact]
        //public void TestMethodSeddlePoint()
        //{
        //    int[,] myArray = { { -8, 0, -3 }, { 6, 4, 8 } };
        //    SecondPart myArr = new SecondPart(myArray);
        //    Assert.Equal("", myArr.GetSedlPoints(2,3));
        //}

    }

}
