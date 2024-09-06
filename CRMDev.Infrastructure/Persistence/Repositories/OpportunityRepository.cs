using CRMDev.Core.Entities;
using CRMDev.Core.Repositories;

namespace CRMDev.Infrastructure.Persistence.Repositories
{
    public class OpportunityRepository : IOpportunityRepository
    {
        private readonly CRMDevDbContext _dbContext;

        public OpportunityRepository(CRMDevDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(Opportunity opportunity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Opportunity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Opportunity?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
