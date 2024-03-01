using BooksManager.Core.Entities;

namespace BooksManager.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<Loan> GetByIdAsync(int id);
        Task AddAsync(Loan loan);
        Task SaveChangesAsync();
    }
}
