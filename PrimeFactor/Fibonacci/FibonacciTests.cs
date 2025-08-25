using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        //Arrange
        int n = 0;
        int expected = 0;
        // Act
        int result = Fibonacci.CalculateFibonacci(n);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        //Arrange
        int n = 10;
        int expected = 55;
        // Act
        int result = Fibonacci.CalculateFibonacci(n);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}