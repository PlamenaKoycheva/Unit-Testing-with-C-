using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> oneElement = new List<int>() { 6};
        List<int> expected = new List<int> { 6};
        

        // Act
        List<int> result = GaussTrick.SumPairs(oneElement);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenCountElements = new () { 7, 2, 5, 6};
        List<int> expected = new List<int> { 13, 7 };


        // Act
        List<int> result = GaussTrick.SumPairs(evenCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddCountElements = new() { 90, 68, 45 };
        List<int> expected = new List<int> { 135, 68 };


        // Act
        List<int> result = GaussTrick.SumPairs(oddCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> largeEvenCountElements = new() { 10, 40, 50, 89, 78, 1 };
        List <int> expected = new List<int> { 11, 118, 139 };


        // Act
        List<int> result = GaussTrick.SumPairs(largeEvenCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> largeOddCountElements = new() { 4, 7, 56, 123, 0, 67 ,43 };
        List<int> expected = new List<int> { 47, 74, 56,123 };


        // Act
        List<int> result = GaussTrick.SumPairs(largeOddCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
