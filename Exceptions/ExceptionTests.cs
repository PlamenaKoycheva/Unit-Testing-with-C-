using NUnit.Framework;

using System;
using System.Collections.Generic;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // Task1
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "Plamena";
        string expected = "anemalP";

        // Act
        string result = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }
    //Task 2

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {

        //Arrange
        decimal totalPrice = 1000;
        decimal discount = 20;
        decimal expected = 800;
        //Act
        decimal result = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 38908.8m;
        decimal discount = -50m;


        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }
        
        [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.TypeOf<ArgumentException>());
    }
    //Task 3
    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array = { 100, 5, 6, 8, 9 };
        int index = 0;
        int expected = 100;
        //Act
        int result = _exceptions.IndexOutOfRangeGetElement(array, index);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 0, 1, 23, 45, 0 };
        int index = -3;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
       //Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.TypeOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 20;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.TypeOf<IndexOutOfRangeException>());
    }
    //Task 4
    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        //Arrange
        bool isLoggedIn = true;
        string expected = "User logged in.";
        //Act
        string result = _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool isLoggedIn = false;
        //Act & Assert 
        Assert.That(() => _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), Throws.TypeOf<InvalidOperationException>());

        try
        {
            _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);
        }
        catch (InvalidOperationException ex)
        {
            Assert.That(ex.Message, Is.EqualTo("User must be logged in to perform this operation."));
        }
    }
    //Task 5
    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        //Arrange
        string input = "123";
        int expected = 123;
        //Act
        int result = _exceptions.FormatExceptionParseInt(input);
        //Assert

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        //Arrange
        string input = "123.8";

        //Act & Assert
        Assert.That(() => _exceptions.FormatExceptionParseInt(input), Throws.TypeOf<FormatException>());

    }
    //Task 6
    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        //Arrange
        Dictionary<string, int> dictionary = new()
        {
            { "Ivan", 9 },
            {"Gosho", 10 }
        };
        string key = "Ivan";
        int expected = 9;
        //Act
        int result = _exceptions.KeyNotFoundFindValueByKey(dictionary, key);

        //Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, int> dictionary = new()
        {
            { "Ivan", 9 },
            {"Gosho", 10 }
        };
        string key = "Plamena";
        //Act & Assert
        Assert.That(() => _exceptions.KeyNotFoundFindValueByKey(dictionary, key), Throws.TypeOf<KeyNotFoundException>());
        

    }
    //Task 7
    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        //Arrange
        int a = 200;
        int b = 100;
        int expected = 300;
        //Act
        int result = _exceptions.OverflowAddNumbers(a, b);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 1;

        //Act & Assert
        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());
        
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = -1;

        //Act & Assert
        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        //Arrange
        int dividend = 9;
        int divisor = 3;
        int expected = 3;
        //Act
        int result = _exceptions.DivideByZeroDivideNumbers(dividend, divisor);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        //Arrange
        int divided = 10;
        int divisor = 0;
        //Act & Assert
        Assert.That(() => _exceptions.DivideByZeroDivideNumbers(divided, divisor), Throws.TypeOf<DivideByZeroException>());
        try
        {
            _exceptions.DivideByZeroDivideNumbers(divided, divisor);
        }
        catch(DivideByZeroException ex)
        {
            Assert.That(ex.Message, Is.EqualTo("Division by zero is not allowed."));
        }
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        //Arrange
        int[] collection = { 1, 2, 3, 4, 5 };
        int index = 3;
        int expected = 15;
        //Act
        int result = _exceptions.SumCollectionElements(collection, index);
        //Asseert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        //Arrange
        int[] collection = null;
        int index = 0;
        //Act & Assert
        Assert.That(() => _exceptions.SumCollectionElements(collection, index), Throws.TypeOf<ArgumentNullException>());
       
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        //Arrange
        int[] collection = {1, 2, 3, 4, 5};
        int index = 10;
        //Act & Assert
        Assert.That(() => _exceptions.SumCollectionElements(collection, index), Throws.TypeOf<IndexOutOfRangeException>());

    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        //Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"one", "1" },
            {"two", "2" }
        };
        string key = "one";
        int expected = 1;
        //Act
        int result = _exceptions.GetElementAsNumber(dictionary, key);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"one", "1" },
            {"two", "2" }
        };
        string key = "five";

        //Act & Assert
        Assert.That(() => _exceptions.GetElementAsNumber(dictionary, key), Throws.TypeOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        //Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"one", "1.1" },
            {"two", "2" }
        };
        string key = "one";

        //Act & Assert
        Assert.That(() => _exceptions.GetElementAsNumber(dictionary, key), Throws.TypeOf<FormatException>());
    }
}
