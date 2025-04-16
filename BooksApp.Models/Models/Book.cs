namespace Books;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int NumberOfPages { get; set; }
    public DateOnly PublishedOn { get; set; }
    public bool IsAvailableInStore { get; set; }
    public Genre Genre { get; set; }

    public Book(string title, string author, int numberOfPages, DateOnly publishedOn, bool isAvailableInStore,
        Genre genre)
    {
        Title = title;
        Author = author;
        NumberOfPages = numberOfPages;
        PublishedOn = publishedOn;
        IsAvailableInStore = isAvailableInStore;
        Genre = genre;
    }

    public Book(Book book)
    {
        Title = book.Title;
        Author = book.Author;
        NumberOfPages = book.NumberOfPages;
        PublishedOn = book.PublishedOn;
        IsAvailableInStore = book.IsAvailableInStore;
        Genre = book.Genre;
    }

    public override string ToString() =>
        $"{Title} by {Author}, Genre: {Genre.ToString()}, Pages: {NumberOfPages}, Published on: {PublishedOn}";

    public int ComputeTimeToRead()
    {
        const int secondsPerPage = 30;

        return NumberOfPages * secondsPerPage;
    }
}