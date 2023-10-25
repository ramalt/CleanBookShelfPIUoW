using CleanBookShelf.Domain.Entites.BookAggregate;
using CleanBookShelf.Domain.Entites.LibraryAggregate;
using CleanBookShelf.Infrastructure.EFCore.configurations;
using Microsoft.EntityFrameworkCore;

namespace CleanBookShelf.Infrastructure.EFCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new BookConfiguration());
        builder.ApplyConfiguration(new LibraryConfiguration());
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Library> Libraries { get; set; }
}
