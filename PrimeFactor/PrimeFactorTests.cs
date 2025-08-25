using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        //Arrange
        long number = 11;
        long expected = 11;
        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        //Arrange
        long number = 48625;
        long expected = 389;
        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
