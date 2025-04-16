using StockApp.Models;

var stock = new Stock<Article>();

var apple = new Article("Apple", 1.5);
var banana = new Article("Banana", 2.5);
var orange = new Article("Orange", 3.5);

stock.AddProduct(apple, 4);
stock.AddProduct(apple);
stock.AddProduct(banana);
stock.AddProduct(orange);

stock.RemoveProduct(apple, 2);
stock.RemoveProduct(apple);

var productList = stock.GetStock();
Console.WriteLine(productList);


Console.WriteLine($"There is/are {stock.GetProductQuantity(apple)} Apples in stock");