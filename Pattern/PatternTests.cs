using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("plamena", 4, "pLaMeNapLaMeNapLaMeNapLaMeNa")]
    [TestCase("Positive Count", 10, "pOsItIvE CoUnTpOsItIvE CoUnTpOsItIvE CoUnTpOsItIvE CoUnTpOsItIvE CoUnTpOsItIvE CoUnTpOsItIvE CoUnTpOsItIvE CoUnTpOsItIvE CoUnTpOsItIvE CoUnT")]
    [TestCase("ONLY UPPERCASE", 2, "oNlY UpPeRcAsEoNlY UpPeRcAsE")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 8;
        string expected = string.Empty;
        //Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor),Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "something";
        int repetitionFactor = -4;
        
        //Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "something";
        int repetitionFactor = 0;

        //Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.TypeOf<ArgumentException>());
    }
}
