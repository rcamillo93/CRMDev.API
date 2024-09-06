using CRMDev.Core.Entities;

namespace CRMDev.Core.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer?> GetByIdAsync(int id);
        Task AddAsync(Customer customer);
        Task SaveChangesAsync();
    }
}
