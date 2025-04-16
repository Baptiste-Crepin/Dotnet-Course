using Car_brands;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarBrands.Tests;

[TestClass]
[TestSubject(typeof(CalculateControls))]
public class CalculateControlsTest
{
    
    [TestMethod]
    public void If2023_Then0()
    {
        // Arrange

        // Act
        var result = CalculateControls.CalculateNumberOfControlsToDate(2023);

        // Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void If2020_Then1()
    {
        // Arrange

        // Act
        var result = CalculateControls.CalculateNumberOfControlsToDate(2020);

        // Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void If2019_Then2()
    {
        // Arrange

        // Act
        var result = CalculateControls.CalculateNumberOfControlsToDate(2019);

        // Assert
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void If2016_Then3()
    {
        // Arrange

        // Act
        var result = CalculateControls.CalculateNumberOfControlsToDate(2016);

        // Assert
        Assert.AreEqual(3, result);
    }
    
    [TestMethod]
    public void If2027_Then0()
    {
        // Arrange

        // Act
        var result = CalculateControls.CalculateNumberOfControlsToDate(2027);

        // Assert
        Assert.AreEqual(0, result);
    }
}