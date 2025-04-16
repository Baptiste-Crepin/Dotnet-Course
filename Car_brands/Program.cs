using Car_brands;

// user inputs

Console.WriteLine("Please enter a vehicle brand:");
string brand = Console.ReadLine() ?? throw new InvalidOperationException("Brand cannot be empty");

Console.WriteLine("Please enter a vehicle model:");
string model = Console.ReadLine() ?? throw new InvalidOperationException("Model cannot be empty");

Console.WriteLine($"The {brand} {model} is a great car.");

// number of controls

Console.WriteLine("Please enter the year the car was first sold:");
int yearOfFirstSale =
    int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("YearOfFirstSale cannot be empty"));

var calculateControls = new CalculateControls();

var numberOfControls = CalculateControls.CalculateNumberOfControlsToDate(yearOfFirstSale);

Console.WriteLine($"This car has {numberOfControls} controls.");

// age

Console.Write("Enter your age: ");
var age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Age cannot be empty"));
Console.WriteLine($"You are {age} years old.");

Console.WriteLine(age >= 18
    ? "You are an adult and you are legally allowed to drive."
    : "You are not an adult and you are not legally allowed to drive.");