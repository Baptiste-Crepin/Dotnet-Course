using System.ComponentModel.DataAnnotations.Schema;

namespace BookEFApp.Models;

public class Auteur
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public DateOnly DateNaissance { get; set; }

    public ICollection<Livre> Livres { get; set; }

    public override string ToString()
    {
        return $"Nom: {Nom}, DateNaissance: {DateNaissance}";
    }
}