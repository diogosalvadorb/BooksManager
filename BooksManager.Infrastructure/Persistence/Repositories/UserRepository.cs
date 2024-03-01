using BooksManager.Core.Entities;
using BooksManager.Core.Repositories;

namespace BooksManager.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> AddAsync(User book)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
