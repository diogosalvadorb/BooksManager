using BooksManager.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BooksManager.Infrastructure.Persistence.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Author)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Isbn)
               .IsRequired()
               .HasMaxLength(13);

            builder.HasIndex(x => x.Isbn)
                .IsUnique();

            builder.Property(x => x.PublicationYear)
               .IsRequired()
               .HasMaxLength(10);

            builder
                .HasMany(x => x.Loans)
                .WithOne(l => l.Book)
                .HasForeignKey(l => l.BookId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
