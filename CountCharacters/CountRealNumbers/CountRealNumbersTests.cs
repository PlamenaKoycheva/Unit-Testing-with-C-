using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {

        // Arrange
        int[] numbers = Array.Empty<int>();
        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int [] {5} ;
        string expected = "5 -> 1";
        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { 5, 100, 90 };
        string expected = "5 -> 1"
                          + Environment.NewLine
                          + "90 -> 1"
                          +Environment.NewLine
                          + "100 -> 1";
        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { -5, -100, -90 };
        string expected = "-100 -> 1"
                          + Environment.NewLine
                          + "-90 -> 1"
                          + Environment.NewLine
                          + "-5 -> 1";
        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { 0, 0, 0, };
        string expected = "0 -> 3";
        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
