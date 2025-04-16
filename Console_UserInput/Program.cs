// See https://aka.ms/new-console-template for more information

namespace Course;

public abstract class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";
        if(string.IsNullOrEmpty(name))
        {
            throw new InvalidOperationException("Name cannot be empty");
        }
        Console.WriteLine($"Hello, {name}!");

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Age cannot be empty"));
        Console.WriteLine($"You are {age} years old.");

        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }
}