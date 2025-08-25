using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        //Arrange
        double x1 = 1.234;
        double y1 = 1.56;
        double x2 = 4.67;
        double y2 = 9.7;
        string expected = "(1.234, 1.56)";
       //Act
       string result = CenterPoint.GetClosest(x1,y1, x2, y2);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        //Arrange
        double x1 = 8.9;
        double y1 = 2.7;
        double x2 = 1.6;
        double y2 = 0.7;
        string expected = "(1.6, 0.7)";
        //Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        //Arrange
        double x1 = 4.5;
        double y1 = 0.5;
        double x2 = 2.5;
        double y2 = 2.5;
        string expected = "(4.5, 0.5)";
        //Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        //Arrange
        double x1 = -1.234;
        double y1 = -1.56;
        double x2 = 4.67;
        double y2 = 9.7;
        string expected = "(-1.234, -1.56)";
        //Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        //Arrange
        double x1 = 1.234;
        double y1 = 0.56;
        double x2 = - 1.234;
        double y2 = -0.56;
        string expected = "(-1.234, -0.56)";
        //Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
