using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        //Arrange
        List <int> listEmpty = new List<int>();
        int[] expected = Array.Empty<int>();
        //Act
        List <int> result = ListManipulation.RemoveNegativesAndReverse(listEmpty);
        //Assert
        Assert.That (result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        //Arrange
        List<int> onlyNegativeNums= new List<int>() { -90, -5, -45};
        List<int> expected = new List<int>();
        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onlyNegativeNums);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        //Arrange
        List<int> onePositiveNum = new List<int>() { 999};
        List<int> expected = new List<int> { 999 };
        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onePositiveNum);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        //Arrange
        List<int> onlyPositiveNums = new List<int>() { 1, 2, 3, 4};
        List<int> expected = new List<int> {4, 3, 2, 1};
        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onlyPositiveNums);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        //Arrange
        List<int> mixedNums = new List<int>() { -67, 0, -34, 68, 4, -9};
        List<int> expected = new List<int> { 4, 68, 0};
        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(mixedNums);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
