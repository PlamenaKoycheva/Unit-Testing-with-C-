using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        //Arrange
        string[] emptyString = Array.Empty<string>();
        


        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(emptyString);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        //Arrange
        string[] oddLengthWord = new string[1] { "cat" };
        string expected = "";

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(oddLengthWord);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        //Arrange
        string[] oddLengthWordOnly = new string[3] { "cat", "mouse", "cow" };
        string expected = "";

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(oddLengthWordOnly);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        //Arrange
        string[] onEvenLengthWord = new string[1] { "mother"};
        string expected = "mother";

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(onEvenLengthWord);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        //Arrange
        string[] evenAndOddLengthWords = new string[5] {"song", "emotion" ,"happy", "lonely", "lovely" };
        string expected = "song lonely lovely";

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(evenAndOddLengthWords);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}

