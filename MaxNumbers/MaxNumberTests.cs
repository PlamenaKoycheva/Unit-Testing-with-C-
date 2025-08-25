using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        //Arrange
        List<int> oneElement = new List<int> { 100 };
        int expected = 100;

        //Act
        int result = MaxNumber.FindMax(oneElement);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> positiveElements = new List<int> { 90, 78, 56, 1000, 5908 };
        int expected = 5908;

        //Act
        int result = MaxNumber.FindMax(positiveElements);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> negativeElements = new List<int> { -98, -700, -34, -93847 };
        int expected = - 34;

        //Act
        int result = MaxNumber.FindMax(negativeElements);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> mixedElements = new List<int> { 0, 90, -3, 87, -67 };
        int expected = 90;

        //Act
        int result = MaxNumber.FindMax(mixedElements);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        //Arrange
        List<int> dupliceteElements = new List<int> { 765, 0, 234, -45, 765};
        int expected = 765;

        //Act
        int result = MaxNumber.FindMax(dupliceteElements);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }
}
