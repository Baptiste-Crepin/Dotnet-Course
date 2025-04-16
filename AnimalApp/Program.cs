using Animal.Models;

var list = new List<Animal.Models.Animal>()
{
    new Chat("Miaous", 23),
    new Chien("Jean-Bouldog", 15, "Amory"),
    new Chat("Myrtille", 5),
    new Chat("Pepite", 2),
    new Chien("JB", 4, "Amory"),
    new Chien("Dingo", 69, "Mikey"),
};

list.Sort();

foreach (var animal in list)
{
    Console.Write($"{animal} ");
    Console.WriteLine(animal.EmettreSon());
}