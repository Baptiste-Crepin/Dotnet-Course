namespace BookEFApp.Models;

public class Livre
{
    public int Id { get; set; }
    public string Titre { get; set; }
    public DateOnly Date { get; set; }

    public int AuteurId { get; set; }
    public Auteur Auteur { get; set; }

    public override string ToString()
    {
        return $"Titre: {Titre}, Date: {Date}, Auteur: {Auteur}";
    }
}