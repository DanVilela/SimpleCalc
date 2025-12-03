using SimpleCalc;
using Xunit;

namespace SimpleCalc.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Fact]
    public void Add_WithPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var a = 10m;
        var b = 5m;

        // Act
        var result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(15m, result);
    }

    [Fact]
    public void Add_WithNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var a = -10m;
        var b = -5m;

        // Act
        var result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(-15m, result);
    }

    [Fact]
    public void Subtract_WithPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        var a = 10m;
        var b = 5m;

        // Act
        var result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(5m, result);
    }

    [Fact]
    public void Multiply_WithPositiveNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        var a = 10m;
        var b = 5m;

        // Act
        var result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(50m, result);
    }

    [Fact]
    public void Divide_WithPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        var a = 10m;
        var b = 5m;

        // Act
        var result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(2m, result);
    }

    [Fact]
    public void Divide_WithZeroDivisor_ThrowsArgumentException()
    {
        // Arrange
        var a = 10m;
        var b = 0m;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.Divide(a, b));
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, 5, 0)]
    public void Add_WithMultipleInputs_ReturnsCorrectSum(decimal a, decimal b, decimal expected)
    {
        // Act
        var result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(100, 10, 10)]
    [InlineData(7, 2, 3.5)]
    public void Divide_WithMultipleInputs_ReturnsCorrectQuotient(decimal a, decimal b, decimal expected)
    {
        // Act
        var result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}