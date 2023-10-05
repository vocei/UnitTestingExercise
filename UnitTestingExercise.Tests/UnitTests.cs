using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(20, 20, 5, 45)] 
        [InlineData(3, 9, 4, 16)] 
        [InlineData(9, 9, 9, 27)] 
        
        
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();
            

            //Act
               var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,7,3)]
        [InlineData(5,2,3)]
        [InlineData(75,6,69)]
        [InlineData(36,3,33)] 
        [InlineData(50,100,-50)] 
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test2 = new Calculator();
            //Act
            var actual = test2.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3,3,9)]
        [InlineData(6,6,36)]
        [InlineData(5,4,20)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test3 = new Calculator();
            //Act
            var actual = test3.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16, 4, 4)]
        [InlineData(45, 9, 5)]
        [InlineData(40, 8, 5)]
        [InlineData(156, 12, 13)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test4 = new Calculator();
            //Act
            var actual = test4.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
