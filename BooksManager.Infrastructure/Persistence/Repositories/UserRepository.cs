using BooksManager.Core.Entities;
using BooksManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BooksManager.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookManagerDbContext _dbContext;
        public UserRepository(BookManagerDbContext context)
        {
            _dbContext = context;
        }
        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await SaveChangesAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(x => x.Id == id && x.Active);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
