using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";
        // Act
       string actual =  StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange 
        string input = "a";
        string expected = "a";

        // Act

        string actual = StringReverse.Reverse(input);

        //Assert
        Assert.That(actual, Is.EqualTo(input));
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "Test String";
        string expected = "gnirtS tseT";

        string actual = StringReverse.Reverse(input);

        Assert.AreEqual(expected, actual);
    }
}
