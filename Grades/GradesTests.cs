using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{

    [Test]


    
    public void Test_GradeAsWords_ReturnsCorrectStrin()
    {
        // Arrange
        double grade = 3.45;
        string expected = "Average";


        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases()
    {
       
        
            // Arrange
            double grade = 1.99;
        string expected = "Invalid!";

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
