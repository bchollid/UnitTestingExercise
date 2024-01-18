using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(10, 0, 0, 10)]
        [InlineData(0, 500, 1, 501)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var newCalculator = new Calculator();

            //Act
            var actual = newCalculator.Add(num1 , num2, num3);

            //Assert
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(100, 0, 100)]
        [InlineData(1, 1, 0)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            ///Arrange
            var newCalculator = new Calculator();

            //Act
            var actual = newCalculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(10, 0, 0)]
        [InlineData(10, 1, 10)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            ///Arrange
            var newCalculator = new Calculator();

            //Act
            var actual = newCalculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(10, 10, 1)]
        [InlineData(10, 1, 10)]
        public void DivideTest(int divisor, int dividend, int expected)
        {
            ///Arrange
            var newCalculator = new Calculator();

            //Act
            var actual = newCalculator.Divide(divisor, dividend);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
