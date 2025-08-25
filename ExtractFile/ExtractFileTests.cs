using NUnit.Framework;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string file = null;

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(file), Throws.TypeOf<ArgumentNullException>());


    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string file = string.Empty;

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(file), Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        //Arrange
        string file = "C:\\Users\\John\\Documents\\example.txt";
        string expected = "File name: example\nFile extension: txt";
        //Act
        string result = ExtractFile.GetFile(file);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        //Arrange
        string file = "C:\\Users\\John\\Documents\\example";
        string expected = "File name: example";
        //Act
        string result = ExtractFile.GetFile(file);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        //Arrange
        string file = "C:\\Users\\John\\Documents?\\example.txt";
        string expected = "File name: example\nFile extension: txt";
        //Act
        string result = ExtractFile.GetFile(file);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
