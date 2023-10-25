using CleanBookShelf.Application.interfaces;
using CleanBookShelf.Domain.Entites.LibraryAggregate;
using CleanBookShelf.Infrastructure.EFCore;

namespace CleanBookShelf.Infrastructure.Repositories;

public class LibraryRepository : ILibraryRepository
{
    private readonly ApplicationDbContext _context;

    public LibraryRepository(ApplicationDbContext context) => _context = context;

    public List<Library> GetAll() => _context.Libraries.ToList();

    public Library GetById(int id) => _context.Libraries.Find(id);

    public void Add(Library library)
    {
        _context.Libraries.Add(library);
        _context.SaveChangesAsync();
    }

    public void Remove(int id)
    {
        var lib = _context.Libraries.Find(id);
        _context.Remove(lib);
        _context.SaveChangesAsync();
    }

    public void Update(Library library)
    {
        _context.Libraries.Update(library);
        _context.SaveChangesAsync();
    }
}
