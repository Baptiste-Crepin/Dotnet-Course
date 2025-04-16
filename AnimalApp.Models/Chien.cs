namespace Animal.Models;

public class Chien : Animal
{
    private string nomDuMaitre { get; set; }

    public Chien(string nom, int age, string nomDuMaitre)
    {
        this.nom = nom;
        this.age = age;
        this.nomDuMaitre = nomDuMaitre;
    }

    public override string ToString()
    {
        return $"{nom} à {age} ans, maitre {nomDuMaitre}";
    }

    public override string EmettreSon()
    {
        return "Woof";
    }
}