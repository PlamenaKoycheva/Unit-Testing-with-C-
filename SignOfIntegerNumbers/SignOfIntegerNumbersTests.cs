using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        //Arrange
        string notIntValue = "something";
        string expected = "The input is not an integer!";
        //Act
        string result = SignOfIntegerNumbers.CheckSign(notIntValue);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        //Arrange
        string zeroInput = "0";
        string expected = "The number 0 is zero.";
        //Act
        string result = SignOfIntegerNumbers.CheckSign(zeroInput);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        //Arrange
        string negativeInput = "-67";
        string expected = "The number -67 is negative.";
        //Act
        string result = SignOfIntegerNumbers.CheckSign(negativeInput);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        //Arrange
        string positiveInput = "987";
        string expected = "The number 987 is positive.";
        //Act
        string result = SignOfIntegerNumbers.CheckSign(positiveInput);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
