namespace Animal.Models;

public class Chat : Animal
{
    public Chat(string nom, int age)
    {
        this.nom = nom;
        this.age = age;
    }

    public override string EmettreSon()
    {
        return "Miaou";
    }
}