using CleanBookShelf.Application.interfaces;

namespace CleanBookShelf.Application.Interfaces;

public interface IRepositoryManager
{
    IBookRepository Book { get; }
    ILibraryRepository Library {get;}
    Task SaveAsync();
}
