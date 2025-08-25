using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        //Arrange
        List<double> grades = new List<double> { 1.99 };
        string expected = "Incorrect grades";
        //Act
        string result = AverageGrade.GetGradeDefinition(grades);
        //Assert
        Assert.That (result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        //Arrange
        List<double> grades = new List<double> { 6.90 };
        string expected = "Incorrect grades";
        //Act
        string result = AverageGrade.GetGradeDefinition(grades);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double> { 2.49 };
        string expected = "Fail";
        //Act
        string result = AverageGrade.GetGradeDefinition(grades);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double> { 3.00 };
        string expected = "Poor";
        //Act
        string result = AverageGrade.GetGradeDefinition(grades);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double> { 4.49 };
        string expected = "Good";
        //Act
        string result = AverageGrade.GetGradeDefinition(grades);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double> { 5.15 };
        string expected = "Very good";
        //Act
        string result = AverageGrade.GetGradeDefinition(grades);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double> { 5.89 };
        string expected = "Excellent";
        //Act
        string result = AverageGrade.GetGradeDefinition(grades);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
