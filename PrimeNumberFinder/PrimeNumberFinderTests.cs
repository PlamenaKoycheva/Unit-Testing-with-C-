using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] arrayEqualsToOne = new int[3] { 1, 0, -3 };
        int[] expected = Array.Empty<int>();

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arrayEqualsToOne);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        //Arrange
        int[] onlyOnePrimeArray = new int[1] { 132 };
        int[] expected = Array.Empty<int>();

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(onlyOnePrimeArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] arrayNoPrimeNumbers = new int[3] { 10, 150, 900 };
        int[] expected = Array.Empty<int>();

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arrayNoPrimeNumbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        //Arrange
        int[] arrayOnlyOnePrimeNumber = new int[3] { 11, 6, 34 };
        int[] expected = {11};

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arrayOnlyOnePrimeNumber);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        //Arrange
        int[] arrayMixedNumbers = new int[5] { 17, 9, 23, 0, 13 };
        int[] expected = {17, 23, 13};

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arrayMixedNumbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
