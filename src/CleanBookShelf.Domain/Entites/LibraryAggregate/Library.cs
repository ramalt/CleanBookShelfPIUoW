using CleanBookShelf.Domain.Entites.BookAggregate;

namespace CleanBookShelf.Domain.Entites.LibraryAggregate;

public class Library
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    private List<Book> _books = new();
    public List<Book> Books => _books.ToList();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }
}
