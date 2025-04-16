namespace FizzBuzz.Tests;

public class FizzBuzz
{
    public string GetFizzBuzzResult(int number)
    {
        const string fizzString = "Fizz";
        const string buzzString = "Buzz";
        string result = "";

        if (number % 3 == 0)
        {
            result += fizzString;
        }

        if (number % 5 == 0)
        {
            result += buzzString;
        }

        if (result == "")
        {
            result = number.ToString();
        }
        
        return result;
    }
}