using CRMDev.Core.Entities;

namespace CRMDev.Core.Repositories
{
    public interface IOpportunityRepository
    {
        Task<List<Opportunity>> GetAllAsync();
        Task<Opportunity?> GetByIdAsync(int id);
        Task AddAsync(Opportunity opportunity);
        Task SaveChangesAsync();
    }
}
