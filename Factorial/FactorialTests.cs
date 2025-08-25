using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        //Arrange
        int input = 0;
        int expected = 1;

        // Act 
        int actual = Factorial.CalculateFactorial(input);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //Arrange
        int input = 7;
        int expected = 5040;

        

        // Act 
        int actual = Factorial.CalculateFactorial(input);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
