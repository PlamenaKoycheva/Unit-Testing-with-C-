using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        //Act
        string result = Miner.Mine(input);
        //Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "Gold 8", "Silver 30" };
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = new string[] { "Gold 8", "Silver 30", "gold 90", "silver 100" };
        string expected = "gold -> 98"
                          + Environment.NewLine
                          + "silver -> 130";
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
