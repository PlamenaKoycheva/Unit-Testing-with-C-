using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();
        string expected = string.Empty;

        // Act

        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));  
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> noAdjacentEqualnums = new List<int> { 1, 2, 3, 4, 5 };
        string expected = "1 2 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualnums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> adjacentEqualnums = new List<int> { 67, 0, 90, 57, 57, 0 };
        string expected = "67 0 90 114 0";

        // Act
        string result = AdjacentEqual.Sum(adjacentEqualnums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> allAdjacentEqualnums = new List<int> {80, 80, 80};
        string expected = "240";

        // Act
        string result = AdjacentEqual.Sum(allAdjacentEqualnums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> beginingAdjacentEqualnums = new List<int> { 2345, 2345, 0, 654, 789};
        string expected = "4690 0 654 789";

        // Act
        string result = AdjacentEqual.Sum(beginingAdjacentEqualnums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> endAdjacentEqualnums = new List<int> { 98, 986, 1, 1 };
        string expected = "98 986 2";

        // Act
        string result = AdjacentEqual.Sum(endAdjacentEqualnums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> middleAdjacentEqualnums = new List<int> { 100, 55, 55, -34};
        string expected = "100 110 -34";

        // Act
        string result = AdjacentEqual.Sum(middleAdjacentEqualnums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
