using CRMDev.Core.Entities;
using CRMDev.Core.Repositories;

namespace CRMDev.Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CRMDevDbContext _dbContext;

        public CustomerRepository(CRMDevDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
