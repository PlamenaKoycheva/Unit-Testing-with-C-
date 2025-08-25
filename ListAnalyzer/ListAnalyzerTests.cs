using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        //Arrange
        List<int> emptyList = new List<int>();
        string expected = "No elements!";
        // Act
        string result = ListAnalyzer.Analyze(emptyList);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        //Arrange
        List<int> oneElement = new List<int> { 345 };
        string expected = "Element count: 1, Min value: 345, Max value: 345, Avg: 345.00.";

        //Act 
        string result = ListAnalyzer.Analyze(oneElement);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        //Arrange
        List<int> sameValueElements = new List<int> { 54, 54, 54 };
        string expected = "Element count: 3, Min value: 54, Max value: 54, Avg: 54.00.";

        //Act 
        string result = ListAnalyzer.Analyze(sameValueElements);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        //Arrange
        List<int> differentValueElements = new List<int> { -560, 0, 356, 1, 34, 76 };
        string expected = "Element count: 6, Min value: -560, Max value: 356, Avg: -15.50.";

        //Act 
        string result = ListAnalyzer.Analyze(differentValueElements);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
