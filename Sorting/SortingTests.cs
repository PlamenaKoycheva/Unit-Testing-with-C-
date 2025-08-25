using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        //Arrange
        double[] emptyArray = Array.Empty<double>();

        // Act 
        double[] result = Sorting.ShallowAscendingSort(emptyArray);

        //Assert
        Assert.That(result, Is.EqualTo(emptyArray));

    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        //Arrange
        double[] emptyArray = Array.Empty<double>();

        // Act 
        double[] result = Sorting.DeepAscendingSort(emptyArray);

        //Assert
        Assert.That(result, Is.EqualTo(emptyArray));
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        //Arrange
        double[] unorderedArray = new double[3] {9, 7, 12};
        double[] expected = { 7, 9, 12 };

        // Act 
        double[] result = Sorting.ShallowAscendingSort(unorderedArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        //Arrange
        double[] unorderedArray = new double[4] { 6, 1, 4, 10};
        double[] expected = { 1, 4, 6, 10 };

        // Act 
        double[] result = Sorting.DeepAscendingSort(unorderedArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
