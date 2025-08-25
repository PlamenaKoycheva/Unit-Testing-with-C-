using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] arrayEvenNums = new int[4] { 2, 4, 6, 8 };
        int evenNumbers = 20;
        int oddNumbers = 0;
        int expected = 20;

        // Act
        int result = EvenOddSubtraction.FindDifference(arrayEvenNums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] arrayOddNums = new int[4] { 1, 3, 5, 7 };
        int evenNumbers = 0;
        int oddNumbers = 16;
        int expected = -16;

        // Act
        int result = EvenOddSubtraction.FindDifference(arrayOddNums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] arrayMixedNums = new int[4] { 2, 4, 9, 11 };
        int evenNumbers = 6;
        int oddNumbers = 20;
        int expected = -14;

        // Act
        int result = EvenOddSubtraction.FindDifference(arrayMixedNums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
