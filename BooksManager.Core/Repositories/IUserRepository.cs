using BooksManager.Core.Entities;

namespace BooksManager.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<User> AddAsync(User book);
        Task SaveChangesAsync();
    }
}
