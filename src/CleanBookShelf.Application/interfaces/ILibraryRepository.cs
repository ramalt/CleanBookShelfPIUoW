using CleanBookShelf.Domain.Entites.LibraryAggregate;

namespace CleanBookShelf.Application.interfaces;

public interface ILibraryRepository
{
    Library GetById(int id);
    void Add(Library library);
    void Update(Library library);
    void Remove(Library library);
    List<Library> GetAll();
}
