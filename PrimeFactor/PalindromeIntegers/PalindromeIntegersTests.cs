using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        //Arrange
        List<int> emptyList = new List<int>();
        //Act 
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(emptyList);
        //Assert
        Assert.That(result, Is.EqualTo(emptyList));
    }
    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        //Arrange
        List<int> noPalindromes = new List<int>() { 97, 56, 456, 23 };
        List<int> expected = new List<int>();
        //Act 
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(noPalindromes);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> singleDigitElements = new List<int>() { 0, 8, 6, 4 };
        List<int> expected = new List<int>() { 0, 8, 6, 4};
        //Act 
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(singleDigitElements);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> allPalindromes = new List<int>() { 11, 101, 626, 5225 };
        List<int> expected = new List<int>() { 11, 101, 626, 5225};
        //Act 
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(allPalindromes);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        //Arrange
        List<int> mixedElements = new List<int>() { 765, 403, 202, 4884, 209, 1001 };
        List<int> expected = new List<int>() { 202, 4884, 1001};
        //Act 
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(mixedElements);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
