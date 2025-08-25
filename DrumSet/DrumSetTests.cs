using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;
//Test a given method which takes in a decimal representing money, list of integers representing quality of drums and a list of strings representing commands.
//For each command each drum is hit by the number indicated.If a drum breaks (goes below or equal to zero) it must be replaced by the initial amount, then initial amount times three must be reduced from the money.If a new drum can’t be afforded it is removed from the list.
//When the command "Hit it again, Gabsy!" is received, the method ends, and returns the current state of the drum set alongside the leftover money.
//The method is found in the DrumSet.cs file:

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        //Arrange
        decimal money = 1234;
        List<int> qualityOfDrums = new List<int>() { 67, 45, 23 };
        List<string> commands = new List<string>();
        //Act
        //Assert
        Assert.That(() => DrumSet.Drum(money, qualityOfDrums, commands), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        //Arrange
        decimal money = 1234;
        List<int> qualityOfDrums = new List<int>() { 67, 45, 23 };
        List<string> commands = new List<string>() { "string"};
        //Act
        //Assert
        Assert.That(() => DrumSet.Drum(money, qualityOfDrums, commands), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 100000000;
        List<int> qualityOfDrums = new List<int>() { 100, 200, 300 };
        List<string> commands = new List<string>() { "Hit it again, Gabsy!" };
        string expected = "100 200 300\nGabsy has 100000000.00lv.";
        //Act
        string result = DrumSet.Drum(money, qualityOfDrums, commands);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 1000;
        List<int> quality = new List<int> { 10 };
        List<string> commands = new List<string> { "15", "Hit it again, Gabsy!" };
        string expected = "10\nGabsy has 970.00lv."; 
        string result = DrumSet.Drum(money, quality, commands);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 20;
        List<int> quality = new List<int> { 10 };
        List<string> commands = new List<string> { "15", "Hit it again, Gabsy!" };
        string expected = "\nGabsy has 20.00lv.";
        string result = DrumSet.Drum(money, quality, commands);
        Assert.That(result, Is.EqualTo(expected));
    }
}
