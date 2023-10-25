using CleanBookShelf.Domain.Entites.BookAggregate;
using CleanBookShelf.Domain.Entites.LibraryAggregate;
using Microsoft.EntityFrameworkCore;

namespace CleanBookShelf.Infrastructure.EFCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Library> Libraries { get; set; }
}
