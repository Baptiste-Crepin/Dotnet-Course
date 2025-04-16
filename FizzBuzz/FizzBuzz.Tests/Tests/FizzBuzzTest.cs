using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests.Tests;

[TestClass]
[TestSubject(typeof(FizzBuzz))]
public class FizzBuzzTest
{
    [TestMethod]
    public void If1_Then1()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
        int indice = 1;

        // Act
        var result = fizzBuzz.GetFizzBuzzResult(indice);

        // Assert
        Assert.AreEqual("1", result);
    }

    [TestMethod]
    public void If2_Then2()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
        int indice = 2;

        // Act
        var result = fizzBuzz.GetFizzBuzzResult(indice);

        // Assert
        Assert.AreEqual("2", result);
    }

    [TestMethod]
    public void If3_ThenFizz()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
        int indice = 3;

        // Act
        var result = fizzBuzz.GetFizzBuzzResult(indice);

        // Assert
        Assert.AreEqual("Fizz", result);
    }

    [TestMethod]
    public void If6_ThenFizz()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
        int indice = 6;

        // Act
        var result = fizzBuzz.GetFizzBuzzResult(indice);

        // Assert
        Assert.AreEqual("Fizz", result);
    }

    [TestMethod]
    public void If5_ThenBuzz()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
        int indice = 5;

        // Act
        var result = fizzBuzz.GetFizzBuzzResult(indice);

        // Assert
        Assert.AreEqual("Buzz", result);
    }

    [TestMethod]
    public void If10_ThenBuzz()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
        int indice = 5;

        // Act
        var result = fizzBuzz.GetFizzBuzzResult(indice);

        // Assert
        Assert.AreEqual("Buzz", result);
    }
    
    [TestMethod]
    public void If15_ThenFizzBuzz()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
        int indice = 15;

        // Act
        var result = fizzBuzz.GetFizzBuzzResult(indice);

        // Assert
        Assert.AreEqual("FizzBuzz", result);
    }    
    
    [TestMethod]
    public void If30_ThenFizzBuzz()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
        int indice = 30;

        // Act
        var result = fizzBuzz.GetFizzBuzzResult(indice);

        // Assert
        Assert.AreEqual("FizzBuzz", result);
    }
}