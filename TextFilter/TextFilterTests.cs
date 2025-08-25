using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "Plamena Valentinova Koycheva";
        string [] banned = Array.Empty<string> ();

        // Act
        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string text = "Words you can use: glass, seaweed.Words you can't use : water, lake, ocean";
        string[] banned = new string[] {"water", "lake", "ocean" };
        string expected = "Words you can use: glass, seaweed.Words you can't use : *****, ****, *****";

        // Act
        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "You have no power here";
        string[] banned = Array.Empty<string>();

        // Act
        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string text = "You have no power here";
        string[] banned = new string[] {"no "};
        string expected = "You have ***power here";

        // Act
        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
