using CRMDev.Core.Entities;
using CRMDev.Core.Repositories;

namespace CRMDev.Infrastructure.Persistence.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly CRMDevDbContext _dbContext;

        public ContactRepository(CRMDevDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
