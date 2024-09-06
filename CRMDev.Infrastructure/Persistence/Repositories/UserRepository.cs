using CRMDev.Core.Entities;
using CRMDev.Core.Repositories;

namespace CRMDev.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CRMDevDbContext _dbContext;

        public UserRepository(CRMDevDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
