using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();
        
        [Fact]
        public void Add_2And3_Returns5()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(5);
        }

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(8);
        }
        

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(6);
        }
        
        [Fact]
        public void Subtract_4And3_Returns1()
        {
            // Arrange
            int a = 4;
            int b = 3;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(1);
        }

        [Fact]
        public void Multiply_4And2_Returns8()
        {
            // Arrange
            int a = 4;
            int b = 2;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(8);
        }
        
        [Fact]
        public void Multiply_5And3_Returns15()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(15);
        }
        
        [Fact]
        public void Multiply_5And2_Returns10()
        {
            // Arrange
            int a = 5;
            int b = 2;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(10);
        }
        
        [Fact]
        public void Divide_10In2_Returns5()
        {
            // Arrange
            int a = 10;
            int b = 2;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.Should().Be(5);
        }
        
        [Fact]
        public void Divide_9In3_Returns3()
        {
            // Arrange
            int a = 9;
            int b = 3;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.Should().Be(3);
        }
    }
}