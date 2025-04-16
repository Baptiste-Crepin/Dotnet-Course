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
        return $"Article: {Name}, Price: {Price}";
    }
}