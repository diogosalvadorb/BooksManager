using BooksManager.Core.Entities;
using BooksManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BooksManager.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookManagerDbContext _dbContext;
        public BookRepository(BookManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _dbContext.Books
                .Include(x => x.Loans)
                .SingleOrDefaultAsync(x => x.Id == id && x.Active);
        }

        public async Task AddAsync(Book book)
        {
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
