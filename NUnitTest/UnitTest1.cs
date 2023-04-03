using Calculator;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace NUnitTest
{
    public class PassingTests
    {
        //Arrange
        public double a = 6;
        public double b = 3;

        [SetUp]
        public void Setup()
        {
        }

        [Author("Jonathan Ochoa")]
        [Test]
        public void WhenAddTwoNumbers_ThenReturnSumOfTwoNumbers()
        {

            var expected = 9;

            //Actual
            var actual = Calculate.DoOperation(a, b, "a");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Author("Jonathan Ochoa")]
        [Test]
        public void WhenSubtractTwoNumbers_ThenReturnFirstNumberMinusSecondNumber()
        {

            var expected = 3;

            //Actual
            var actual = Calculate.DoOperation(a, b, "b");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Author("Jonathan Ochoa")]
        [Test]
        public void WhenMultiplyTwoNumbers_ThenReturnMultiplicationOfTwoNumbers()
        {

            var expected = 18;

            //Actual
            var actual = Calculate.DoOperation(a, b, "c");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Author("Jonathan Ochoa")]
        [Test]
        public void WhenDivideTwoNumbers_ThenReturnDivisionOfTwoNumbers()
        {

            var expected = 2;

            //Actual
            var actual = Calculate.DoOperation(a, b, "d");

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }

    //fail test due to illegal argument exception
    public class FailureTest
    {
        [Test]
        public void WhenDivideByZero_ThrowIllegalArgumentException()
        {
            //Arrange
            double a = 10;
            double b = 0;

            //Assert
            Calculate.DoOperation(a, b, "d");
         
        }
    }
}