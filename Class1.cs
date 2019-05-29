using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp13;
using NUnit.Framework;

namespace SENG8040_ASSIGNMENT_TEST
{
    [TestFixture]
    public class SENG8040_ASSIGNMENT_TEST
    {


        [Test]
        public void GetLength_Input12_Returns12()
        {

            //Arrange
            int length = 12;
            int width = 10;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetWidth_Input30_Returns30()
        {

            //Arrange
            int length = 10;
            int width = 30;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SetLength_Input15_Returns15()
        {

            //Arrange
            int length = 15;
            int width = 12;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetLength(length);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}


