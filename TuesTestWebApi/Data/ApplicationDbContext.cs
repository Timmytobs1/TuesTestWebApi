using Microsoft.EntityFrameworkCore;
using TuesTestWebApi.Model;

namespace TuesTestWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

       public DbSet<Customer> Customers { get; set; }

       public DbSet<Account> Accounts { get; set; }

        public DbSet<Transactions> Transactions { get; set; }

    }
}
