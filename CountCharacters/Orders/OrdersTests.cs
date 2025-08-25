using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
       //Arrange 
       string[] input = Array.Empty<string>();
        //Act
        string result = Orders.Order(input);
        //Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new[]
{
    "apple 1.99 1",
    "banana 1.25 2",   
    "banana 1.25 1",
    "apple 1.99 2",
    "orange 0.99 0",   
    "orange 0.99 2"
};
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        //Arrange 
        string[] input = new[] { "apple 3.00 5", "banana 2.00 5", "orange 4.00 10" };
        string expected = "apple -> 15.00"
                           + Environment.NewLine
                           + "banana -> 10.00"
                           + Environment.NewLine
                           + "orange -> 40.00";
        //Act
        string result = Orders.Order(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        //Arrange 
        string[] input = new[] { "apple 3.00 5.25", "banana 2.00 5.90", "orange 4.00 10.64" };
        string expected = "apple -> 15.75"
                           + Environment.NewLine
                           + "banana -> 11.80"
                           + Environment.NewLine
                           + "orange -> 42.56";
        //Act
        string result = Orders.Order(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
