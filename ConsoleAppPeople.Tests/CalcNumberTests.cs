using System;
using Xunit;
using ConsoleAppPeople;
using System.Collections.Generic;

namespace ConsoleAppPeople.Tests
{
    public class CalcNumberTests
    {
        [Fact]
        public void AddTwoNumbers()
        {
            //Arrange
            double numberA = 3.3;
            double numberB = 2.2;
            double expected = 5.5;

            //Act
            double result = CalcNumber.Addition(numberA, numberB);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AddTwoNegativNumbers()
        {
            //Arrange
            double numberA = -3.3;
            double numberB = -2.2;
            double expected = -5.5;

            //Act
            double result = CalcNumber.Addition(numberA, numberB);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AddThreeNumbers()
        {
            //Arrange
            double numberA = 3.3;
            double numberB = 2.2;
            double numberC = 5.5;
            double expected = 11.0;

            //Act
            double result = CalcNumber.Addition(numberA, numberB, numberC);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AddArrayOfNumbers()
        {
            //Arrange
            double[] numbers = new double[] { 1.1, 2.2, 3.3 };
            double expected = 6.6;

            //Act
            double result = CalcNumber.Addition(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AddArrayOfNull()
        {
            //Arrange
            double expected = 0;

            //Act
            double result = CalcNumber.Addition(null);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AddEmptyArray()
        {
            //Arrange
            double expected = 0;

            //Act
            double result = CalcNumber.Addition(new double[0]);

            //Assert
            Assert.Equal(expected, result);
        }

        //---- Sub --------------------------------------------------------------------------------------

        [Fact]
        public void SubTwoNumbers()
        {
            //Arrange
            double numberA = 3.3;
            double numberB = 2.2;
            double expected = 1.1;

            //Act
            double result = CalcNumber.Subtration(numberA, numberB);

            //Assert
            Assert.Equal(expected, result, 1);
        }

        [Fact]
        public void SubArrayOfNumbers()
        {
            //Arrange
            double[] numbers = new double[] { 3.3, 2.2, 1.1 };
            double expected = 0.0;

            //Act
            double result = CalcNumber.Subtration(numbers);

            //Assert
            Assert.Equal(expected, result, 1);
        }

        [Fact]
        public void SubArrayOfNegativNumbers()
        {
            //Arrange
            double[] numbers = new double[] { -12, -3, 5, 24 };
            double expected = -38;

            //Act
            double result = CalcNumber.Subtration(numbers);

            //Assert
            Assert.Equal(expected, result, 1);
        }

        [Fact]
        public void SubArrayOfNull()
        {
            //Arrange
            double expected = 0;

            //Act
            double result = CalcNumber.Subtration(null);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubEmptyArray()
        {
            //Arrange
            double expected = 0;

            //Act
            double result = CalcNumber.Subtration(new double[0]);

            //Assert
            Assert.Equal(expected, result);
        }

        //---- Multi --------------------------------------------------------------------------------------

        [Fact]
        public void MultiTwoNumbers()
        {
            //Arrange
            double numberA = 3.3;
            double numberB = 2.2;
            double expected = 7.26;

            //Act
            double result = CalcNumber.Multiplication(numberA, numberB);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void MultiArrayOfNumbers()
        {
            //Arrange
            double[] numbers = new double[] { 3.3, 2.2, 1.1 };
            double expected = 7.986;

            //Act
            double result = CalcNumber.Multiplication(numbers);

            //Assert
            Assert.Equal(expected, result, 3);
        }

        [Fact]
        public void MultiArrayOfNegativNumbers()
        {
            //Arrange
            double[] numbers = new double[] { -12, -3, 5, 24 };
            double expected = 4_320;//double expected = 4320;

            //Act
            double result = CalcNumber.Multiplication(numbers);

            //Assert
            Assert.Equal(expected, result, 1);
        }

        [Fact]
        public void MultiArrayOfNull()
        {
            //Arrange
            double expected = 0;

            //Act
            double result = CalcNumber.Multiplication(null);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MultiEmptyArray()
        {
            //Arrange
            double expected = 0;

            //Act
            double result = CalcNumber.Multiplication(new double[0]);

            //Assert
            Assert.Equal(expected, result);
        }

        //---- Div --------------------------------------------------------------------------------------

        [Fact]
        public void DivTwoNumbers()
        {
            //Arrange
            double numberA = 3.3;
            double numberB = 2.2;
            double expected = 1.5;

            //Act
            double result = CalcNumber.Divide(numberA, numberB);

            //Assert
            Assert.Equal(expected, result, 1);
        }

        [Fact]
        public void DivArrayOfNumbers()
        {
            //Arrange
            double[] numbers = new double[] { 3.3, 2.2, 1.1 };
            double expected = 1.3636;

            //Act
            double result = CalcNumber.Divide(numbers);

            //Assert
            Assert.Equal(expected, result, 4);
        }

        [Fact]
        public void DivArrayOfNegativNumbers()
        {
            //Arrange
            double[] numbers = new double[] { -12, -3, 5, 24 };
            double expected = 0.0333;
            //Act
            double result = CalcNumber.Divide(numbers);

            //Assert
            Assert.Equal(expected, result, 4);
        }

        [Fact]
        public void DivByZero()
        {
            //Arrange
            double numberA = 42;
            double numberB = 0;

            //Assert                                    //Act
            Assert.Throws<DivideByZeroException>( () => CalcNumber.Divide(numberA, numberB));         
        }

        [Fact]
        public void DivZeroWithNumber()
        {
            //Arrange
            double numberA = 0;
            double numberB = 42;
            double expected = 0;

            //Act
            double result = CalcNumber.Divide(numberA, numberB);
            
            //Assert
            Assert.Equal(expected, result, 0);
        }

        [Fact]
        public void DivArrayOfNull()
        {
            //Arrange
            double expected = 0;

            //Act
            double result = CalcNumber.Divide(null);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivEmptyArray()
        {
            //Arrange
            double expected = 0;

            //Act
            double result = CalcNumber.Divide(new double[0]);

            //Assert
            Assert.Equal(expected, result);
        }

        //---- bonus ------------------------------------------------------------------------------------

        //Alternetiv way to use Theory
        public static IEnumerable<object[]> GetNumbers()
        {   //for AddArrayWithMemberData               numbers       expected                                         
            yield return new object[] { new double[] { 5, 1, 3, 9 }, 18 };
            yield return new object[] { new double[] { 7, 1, 5, 3 }, 16 };
        }

        [Theory]
        [MemberData(nameof(GetNumbers))]
        public void AddArrayWithMemberData(double[] numbers, int expected)
        {
            //Arrange

            //Act
            double result = CalcNumber.Addition(numbers);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
