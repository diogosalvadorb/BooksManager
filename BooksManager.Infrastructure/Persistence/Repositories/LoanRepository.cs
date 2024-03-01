using BooksManager.Core.Entities;
using BooksManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BooksManager.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly BookManagerDbContext _dbContext;
        public LoanRepository(BookManagerDbContext context)
        {
            _dbContext = context;
        }
        public async Task AddAsync(Loan loan)
        {
            await _dbContext.Loans.AddAsync(loan);
            await SaveChangesAsync();
        }

        public async Task<Loan> GetByIdAsync(int id)
        {
            return await _dbContext.Loans
                .Include(x => x.Book)
                .Include(x => x.User)
                .SingleOrDefaultAsync(x => x.Id == id && x.Active);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
