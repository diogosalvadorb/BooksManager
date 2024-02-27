using BooksManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksManager.Infrastructure.Persistence
{
    public class BookManagerDbContext : DbContext
    {
        public BookManagerDbContext(DbContextOptions<BookManagerDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
