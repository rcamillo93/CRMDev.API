using CRMDev.Core.Entities;

namespace CRMDev.Core.Repositories
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAllAsync();
        Task<Contact?> GetByIdAsync(int id);
        Task AddAsync(Contact contact);
        Task SaveChangesAsync();
    }
}
