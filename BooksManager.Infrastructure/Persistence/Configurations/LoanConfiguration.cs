using BooksManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksManager.Infrastructure.Persistence.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder
                .HasOne(x => x.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId)
                .IsRequired();

            builder
                 .HasOne(x => x.User)
                 .WithMany(u => u.Loans)
                 .HasForeignKey(l => l.UserId)
                 .IsRequired();

            builder
                .Property(x => x.LoanDate)
                .IsRequired();

            builder
                .Property(x => x.LoanDate)
                .IsRequired(false);
        }
    }
}
