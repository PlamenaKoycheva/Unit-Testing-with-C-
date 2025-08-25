using System;
using System.IO;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new[]{1, 2, 3, 4, 5, 6, 7, 8}, "5 5 13 13")]
    [TestCase(new[] { 0, 0, 0, 0 ,0, 0, 0}, "0 0")]
    [TestCase(new[] { -1, 2, -3, 4, 5, -6, 7, -8 }, "-1 3 -3 1")]
    [TestCase(new[] {  100, 67, 1234, 9}, "167 1243")]
    [TestCase(new[] { -78, -34, -700, -5}, "-112 -705")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        //Act
        string result = FoldSum.FoldArray(arr);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
