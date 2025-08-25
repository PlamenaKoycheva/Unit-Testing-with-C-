using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";
        bool expected = true;

        // Act
       bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(result);
    }

    [TestCase ("prodanowagmail.com")]
    
    [TestCase ("@gmail.com")]
    public void Test_IsValidEmail_InvalidEmail(string inValidEmail)
    {
        // Arrange
        
        bool expected = false;

        // Act
        bool result = Email.IsValidEmail(inValidEmail);

        // Assert
        Assert.IsFalse(result);
    }
        [Test]
        public void Test_IsValidEmail_NullInput()
        {
        // Arrange
        string inValidEmail = string.Empty;
        bool expected = false;

        // Act
        bool result = Email.IsValidEmail(inValidEmail);

        // Assert
        Assert.IsFalse(result);
    }
    }
