using CRMDev.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRMDev.Infrastructure.Persistence
{
    public class CRMDevDbContext : DbContext
    {
        protected CRMDevDbContext(DbContextOptions<CRMDevDbContext> options) :base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
    }
}
