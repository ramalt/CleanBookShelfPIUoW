using CleanBookShelf.Application.interfaces;
using CleanBookShelf.Application.Interfaces;
using CleanBookShelf.Infrastructure.EFCore;
using CleanBookShelf.Infrastructure.Repositories;

namespace CleanBookShelf.Infrastructure.Persistence;

public class RepositoryManager : IRepositoryManager
{
    private readonly ApplicationDbContext _context;
    private readonly Lazy<IBookRepository> _bookRepository;
    private readonly Lazy<ILibraryRepository> _libraryRepository;

    public RepositoryManager(ApplicationDbContext context)
    {
        _context = context;
        _libraryRepository = new Lazy<ILibraryRepository>(() => new LibraryRepository(_context));
        _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(_context));
    }

    public IBookRepository Book => _bookRepository.Value;

    public ILibraryRepository Library => _libraryRepository.Value;

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}
