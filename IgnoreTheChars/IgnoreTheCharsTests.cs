using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        //Arrange
        string emptyString = string.Empty;
        List <char> chars = new List<char>() { 'c', 'f'};
        string expected = string.Empty;
        //Act
        string result = IgnoreTheChars.IgnoreChars(emptyString, chars);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        //Arrange
        string sentence = "My name is Plamena";
        List<char> charsEmpty = new List<char>() ;
        string expected = "My name is Plamena";
        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, charsEmpty);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "a";
        List<char> charsToIgnore = new List<char>() { 'a'};
        string expected = string.Empty;
        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, charsToIgnore);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        //Arrange
        string sentence = "My test for chars";
        List<char> charsToIgnore = new List<char>() { 'a', 'f', 'o'};
        string expected = "My test r chrs";
        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, charsToIgnore);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
