using System.Globalization;

namespace StockApp.Models;

public class Article
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Article(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        var culture = new CultureInfo("fr-FR");
        return $"Name: {Name}, Price: {Price.ToString("C", culture)}";
    }
}