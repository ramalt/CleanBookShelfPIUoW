using CleanBookShelf.Application.interfaces;
using CleanBookShelf.Application.Interfaces;
using CleanBookShelf.Infrastructure.EFCore;
using CleanBookShelf.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanBookShelf.Infrastructure;

public static class Extensions
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(opt => {
            opt.UseSqlServer("Server=localhost,1433;Database=BookshelfDb;User=sa;Password=Root1234!;TrustServerCertificate=true");
        });

        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<ILibraryRepository, LibraryRepository>();
    }
}
