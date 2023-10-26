using CleanBookShelf.Domain.Entites.BookAggregate;

namespace CleanBookShelf.Application.Interfaces;

public interface IBookRepository : IRepository<Book>
{
    Book GetById(int id);
    void Add(Book book);
    void Update(Book book);
    void Remove(Book book);
    List<Book> GetAll();
}
