using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        //Act
        string result = OddOccurrences.FindOdd(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = new string [] {"moo", "moo"} ;
        string expected = string.Empty;
        //Act
        string result = OddOccurrences.FindOdd(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        //Arrange
        string[] input = new string[] { "moo", "cow", "moo" };
        string expected = "cow";
        //Act
        string result = OddOccurrences.FindOdd(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        //Arrange
        string[] input = new string[] { "ab", "ab", "ab", "cd", "go" };
        string expected = "ab cd go";
        //Act
        string result = OddOccurrences.FindOdd(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        //Arrange
        string[] input = new[] { "Java", "C#", "java", "Python", "PYTHON", "PYTHON" };
        string expected = "c# python";
        //Act
        string result = OddOccurrences.FindOdd(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
