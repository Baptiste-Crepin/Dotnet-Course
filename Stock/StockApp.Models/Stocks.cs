namespace StockApp.Models;

public class Stocks
{
    private Dictionary<Article, int> ProductsDict { get; set; }

    public Stocks(Dictionary<Article, int>? productsList = null)
    {
        ProductsDict = new Dictionary<Article, int>();
    }

    public void AddProduct(Article article)
    {
        var existing = ProductsDict.Keys.FirstOrDefault(a => a.Name == article.Name);

        if (existing != null)
        {
            ProductsDict[existing]++;
            return;
        }

        ProductsDict.Add(article, 1);
    }

    public void RemoveProductById(string identifier)
    {
        // Identifier is the name of the product
        var existing = ProductsDict.Keys.FirstOrDefault(a => a.Name == identifier);

        if (existing == null)
        {
            throw new Exception("Product is not inside the stock");
        }

        ProductsDict[existing]--;

        if (ProductsDict[existing] == 0)
        {
            ProductsDict.Remove(existing);
        }
    }

    public Dictionary<Article, int> GetStock()
    {
        return ProductsDict;
    }

    public int GetProductQuantity(string productName)
    {
        var product = ProductsDict.FirstOrDefault(x => x.Key.Name == productName);
        if (product.Equals(default(KeyValuePair<Article, int>)))
        {
            return 0;
        }

        return product.Value;
    }
}