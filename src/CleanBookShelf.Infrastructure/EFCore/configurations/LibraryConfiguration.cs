using CleanBookShelf.Domain.Entites.LibraryAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanBookShelf.Infrastructure.EFCore.configurations;

public class LibraryConfiguration : IEntityTypeConfiguration<Library>
{
    public void Configure(EntityTypeBuilder<Library> builder)
    {
           builder.ToTable("Libraries"); // Veritabanında hangi tabloya karşılık geldiğini belirtin

        builder.HasKey(l => l.Id); // Kütüphanenin benzersiz kimliği olarak Id kullanın

        builder.Property(l => l.Name).IsRequired().HasMaxLength(100).HasColumnType("TEXT"); // Kütüphane adını zorunlu ve maksimum 100 karakter olarak ayarlayın

        // Kütüphane ile kitap arasında bir ilişki kurun
        builder.HasMany(l => l.Books)
            .WithOne()
            .HasForeignKey(b => b.Id);
    }
}
