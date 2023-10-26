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

    public void Add(Library library) => _context.Libraries.Add(library);

    public void Remove(Library library) => _context.Remove(library);

    public void Update(Library library) => _context.Libraries.Update(library);

}
