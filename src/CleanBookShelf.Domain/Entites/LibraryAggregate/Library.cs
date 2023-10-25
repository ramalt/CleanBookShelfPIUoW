using CleanBookShelf.Domain.Entites.BookAggregate;

namespace CleanBookShelf.Domain.Entites.LibraryAggregate;

public class Library
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    private List<Book> _books;

    public Library(int id, string name)
    {
        Id = id;
        Name = name;
        _books = new List<Book>();
    }
}
