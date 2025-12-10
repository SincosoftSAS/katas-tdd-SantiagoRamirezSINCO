using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);
            
            // Assert
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }
        
        [Fact]
        public void Generate_WithTwo_ReturnsListWithOneAndTwo()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(2);
            
            // Assert
            result.Should().HaveCount(2);
            result.Should().BeEquivalentTo(["1","2"]);
        }
        
        [Fact]
        public void Generate_WithThree_ReturnsListWithFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(3);
            
            // Assert
            result.Should().HaveCount(3);
            result[2].Should().BeEquivalentTo("Fizz");
        }
        
        [Fact]
        public void Generate_WithSix_ReturnsListWithFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(6);
            
            // Assert
            result.Should().HaveCount(6);
            result[5].Should().BeEquivalentTo("Fizz");
        }
        
        [Theory]
        [InlineData(9)]
        [InlineData(72)]
        [InlineData(33)]
        [InlineData(18)]
        [InlineData(12)]
        public void Generate_WithNumberDivisibleInThree_ReturnsListWithFizz(int number)
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(number);
            
            // Assert
            result.Should().HaveCount(number);
            result[number - 1].Should().BeEquivalentTo("Fizz");
        }
        
        [Fact]
        public void Generate_WithFive_ReturnsListWithBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(5);
            
            // Assert
            result.Should().HaveCount(5);
            result[4].Should().BeEquivalentTo("Buzz");
        }
        
        [Fact]
        public void Generate_WithTen_ReturnsListWithBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(10);
            
            // Assert
            result.Should().HaveCount(10);
            result[9].Should().BeEquivalentTo("Buzz");
        }
        
        [Theory]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(35)]
        [InlineData(40)]
        [InlineData(100)]
        public void Generate_WithNumberDivisibleByFive_ReturnsListWithBuzz(int number)
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(number);
            
            // Assert
            result.Should().HaveCount(number);
            result[number - 1].Should().BeEquivalentTo("Buzz");
        }
        
        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);
            
            // Assert
            result.Should().HaveCount(15);
            result[14].Should().Be("FizzBuzz");
        }
        
        [Fact]
        public void Generate_Withthirty_ReturnsListWithFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(30);
            
            // Assert
            result.Should().HaveCount(30);
            result[29].Should().Be("FizzBuzz");
        }
        
        [Theory]
        [InlineData(45)]
        [InlineData(60)]
        [InlineData(120)]
        [InlineData(90)]
        [InlineData(195)]
        public void Generate_WithNumberDivisibleByFiveAndThree_ReturnsListWithFizzBuzz(int number)
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(number);
            
            // Assert
            result.Should().HaveCount(number);
            result[number - 1].Should().BeEquivalentTo("FizzBuzz");
        }
        
        
        [Fact]
        public void Generate_WithFifthteen_ReturnsListWithSecuence()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);
            
            // Assert
            result.Should().HaveCount(15);
            result.Should().BeEquivalentTo(["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]);
        }
    }
}