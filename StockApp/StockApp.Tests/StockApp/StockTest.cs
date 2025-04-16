using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockApp.Models;

namespace StockApp.Tests.StockApp;

[TestClass]
[TestSubject(typeof(Stock<Article>))]
public class StockTest
{
    [TestMethod]
    public void EmptyStockShouldReturnEmptyString()
    {
        // Arange
        Stock<Article> stock = new();

        // Act
        string stockItems = stock.GetStock();

        // Assert
        Assert.AreEqual("", stockItems);
    }

    [TestMethod]
    public void AddProductToStockShouldReturnProduct()
    {
        // Arange
        Stock<Article> stock = new();
        var apple = new Article("Apple", 1.5);

        // Act
        stock.AddProduct(apple);
        string stockItems = stock.GetStock();

        // Assert
        Assert.AreEqual("Product: Name: Apple, Price: 1,50 €, Quantity: 1\n", stockItems);
    }

    [TestMethod]
    public void AddArticlesTwiceToStocksShouldReturnProductWithQuantity2()
    {
        // Arange
        Stock<Article> stock = new();
        var apple = new Article("Apple", 1.5);

        // Act
        stock.AddProduct(apple);
        stock.AddProduct(apple);
        string stockItems = stock.GetStock();

        // Assert
        Assert.AreEqual("Product: Name: Apple, Price: 1,50 €, Quantity: 2\n", stockItems);
    }

    [TestMethod]
    public void Add2ArticlesToStocksShouldReturnProductWithQuantity2()
    {
        // Arange
        Stock<Article> stock = new();
        var apple = new Article("Apple", 1.5);

        // Act
        stock.AddProduct(apple, 2);
        string stockItems = stock.GetStock();

        // Assert
        Assert.AreEqual<string>("Product: Name: Apple, Price: 1,50 €, Quantity: 2\n", stockItems);
    }
    
    [TestMethod]
    public void RemoveProductFromStockShouldReturnEmptyString()
    {
        // Arange 
        Stock<Article> stock = new();

        var apple = new Article("Apple", 1.5);

        // Act

        stock.AddProduct(apple);
        stock.RemoveProduct(apple);
        var stockItems = stock.GetStock();

        // Assert
        Assert.AreEqual("", stockItems);
    }
}