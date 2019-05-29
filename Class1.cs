﻿using System;
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


    }
}

