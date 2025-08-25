using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] plants = Array.Empty<string>();
        //Act 
        string result = Plants.GetFastestGrowing(plants);
        //Assert
        Assert.That(result, Is.Empty);



    }
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new[] { "avocado"};
        string expected = "Plants with 7 letters:" +
                           Environment.NewLine
                           +"avocado";
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new[] { "avocado", "papaya", "pumpkin" };
        string expected = "Plants with 6 letters:"
            +Environment.NewLine
            + "papaya"
            +Environment.NewLine
            +"Plants with 7 letters:" +
                           Environment.NewLine
                           + "avocado"
                           +Environment.NewLine
                           + "pumpkin";
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new[] { "Avocado", "Papaya", "Pumpkin" };
        string expected = "Plants with 6 letters:"
            + Environment.NewLine
            + "Papaya"
            + Environment.NewLine
            + "Plants with 7 letters:" +
                           Environment.NewLine
                           + "Avocado"
                           + Environment.NewLine
                           + "Pumpkin";
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
