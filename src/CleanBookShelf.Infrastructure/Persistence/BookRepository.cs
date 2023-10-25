using CleanBookShelf.Application.Interfaces;
using CleanBookShelf.Domain.Entites.BookAggregate;
using CleanBookShelf.Infrastructure.EFCore;

namespace CleanBookShelf.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly ApplicationDbContext _context;

    public BookRepository(ApplicationDbContext context) => _context = context;

    public void Add(Book book) => _context.Books.Add(book);

    public List<Book> GetAll() => _context.Books.ToList();

    public Book GetById(int id) => _context.Books.Find(id);

    public void Remove(Book book) => _context.Books.Remove(book);

    public void Update(Book book) => _context.Books.Update(book);
}
