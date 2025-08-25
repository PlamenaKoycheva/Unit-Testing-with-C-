using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        //Arrange
        string emptyString = string.Empty;
        string expected = "Empty string";
        //Act
        string result = MiddleCharacters.GetMiddleChars(emptyString);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        //Arrange
        string whiteSpace = " ";
        string expected = "Empty string";
        //Act
        string result = MiddleCharacters.GetMiddleChars(whiteSpace);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        //Arrange
        string singleCharString = "o";
        string expected = "o";
        //Act
        string result = MiddleCharacters.GetMiddleChars(singleCharString);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        //Arrange
        string  evenStringLength = "Koycheva";
        string expected = "ch";
        //Act
        string result = MiddleCharacters.GetMiddleChars(evenStringLength);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        //Arrange
        string oddStringLength = "Plamena";
        string expected = "m";
        //Act
        string result = MiddleCharacters.GetMiddleChars(oddStringLength);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
