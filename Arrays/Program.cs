double[] temperatures = new double[10];
Random random = new Random(DateTime.Now.Millisecond);

for (int i = 0; i < temperatures.Length; i++)
{
    double input;
    bool validInput = false;

    while (!validInput)
    {
        Console.Write($"Entrez la température #{i + 1} (entre -10 et 35) : ");
        // string userInput = Console.ReadLine();
        double temperature = random.NextDouble() * (35 - (-10)) + (-10);
        string userInput = temperature.ToString("F1");

        if (double.TryParse(userInput, out input))
        {
            if (input >= -10 && input < 35)
            {
                temperatures[i] = input;
                validInput = true;
            }
            else
            {
                Console.WriteLine("La température doit être comprise entre -10 (inclus) et 35 (exclus).");
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre valide.");
        }

        Console.WriteLine($"Selected temperature: {temperatures[i]}°C");
    }
}

