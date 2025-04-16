using BookEFApp.Models;

namespace BookEFApp.Dal;

public class BookStoreService
{
    private readonly IDalBookStore _dalBookStore;

    public BookStoreService(IDalBookStore dalBookStore)
    {
        _dalBookStore = dalBookStore;
    }

    public List<Auteur> GetAuteursBeforeDate(DateOnly date)
    {
        if(date.Year < 1900)
        {
            throw new HorsSujetException("Vous ne pouvez pas rechercher des auteurs nés avant 1900", date);
        }
        
        var auteurs = _dalBookStore.GetAuteurs();
        var auteursBeforeDate = auteurs.Where(a => a.DateNaissance < date).ToList();
        
        return auteursBeforeDate;
    }
}