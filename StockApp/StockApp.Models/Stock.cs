using System.Text;

namespace StockApp.Models;

public class Stock<T> where T : class
{
    private Dictionary<T, int> ProductsDict { get; set; }

    public Stock(Dictionary<T, int>? productsList = null)
    {
        ProductsDict = new Dictionary<T, int>();
    }

    public void AddProduct(T item, int quantity = 1)
    {
        if (quantity < 0)
        {
            throw new Exception("Quantity cannot be negative number");
        }

        if (ProductsDict.ContainsKey(item))
        {
            ProductsDict[item] += quantity;
            return;
        }

        ProductsDict.Add(item, quantity);
    }

    public bool RemoveProduct(T item, int quantity = 1)
    {
        if (!ProductsDict.ContainsKey(item))
        {
            return false;
        }

        var currentQuantity = ProductsDict[item];

        if (currentQuantity - quantity < 0)
        {
            return false;
        }

        if (currentQuantity - quantity == 0)
        {
            ProductsDict.Remove(item);
            return true;
        }

        ProductsDict[item] -= quantity;
        return true;
    }

    public string GetStock()
    {
        StringBuilder bs = new StringBuilder();

        foreach (var product in ProductsDict)
        {
            bs.AppendLine($"Product: {product.Key}, Quantity: {product.Value}");
        }

        return bs.ToString();
    }

    public int GetProductQuantity(T item)
    {
        return ProductsDict.ContainsKey(item) ? ProductsDict[item] : 0;
    }
}