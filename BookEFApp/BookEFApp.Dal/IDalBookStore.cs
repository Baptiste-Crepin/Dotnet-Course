using BookEFApp.Models;

namespace BookEFApp.Dal;

public interface IDalBookStore
{
    List<Auteur> GetAuteurs();
}