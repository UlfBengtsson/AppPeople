﻿using System;
using Xunit;
using ConsoleAppPeople;

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
    }
}
